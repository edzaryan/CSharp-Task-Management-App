using Newtonsoft.Json;
using ToDoListApplication;


string fileFullName = "C:\\Users\\Dell\\OneDrive\\Desktop\\CSharp-Task-Management-App\\Utils\\data.json";


if (File.Exists(fileFullName))
{
    try {
        string jsonData = File.ReadAllText(fileFullName);

        dynamic json = JsonConvert.DeserializeObject(jsonData);

        List<string> userNames = json.userNames.ToObject<List<string>>();
        List<string> taskNames = json.taskNames.ToObject<List<string>>();

        List<User> users = new();
        List<UserTask> tasks = new();

        foreach (string userName in userNames)
        {
            users.Add(new User(userName));
        }

        foreach (string taskName in taskNames)
        {
            tasks.Add(new UserTask(taskName));
        }

        Manager manager = new();

        manager.SendUsersTasks(
            new List<User>() { users[0], users[1] },
            new List<UserTask>() { tasks[0], tasks[1], tasks[2] }
        );
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
}
else
{
    Console.WriteLine("The JSON file does not exist.");
}







