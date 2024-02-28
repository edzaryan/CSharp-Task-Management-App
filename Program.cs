using Newtonsoft.Json;
using ToDoListApplication;


string jsonFileName = "data.json";
string jsonFilePath = Path.Combine(
    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
    jsonFileName
);


if (File.Exists(jsonFilePath))
{
    string jsonData = File.ReadAllText(jsonFilePath);

    dynamic json = JsonConvert.DeserializeObject(jsonData);

    List<string> userNames = json.userNames.ToObject<List<string>>();
    List<string> taskNames = json.taskNames.ToObject<List<string>>();

    List<User> users = new();
    List<UserTask> tasks = new();

    foreach (string userName in userNames)
        users.Add(new User(userName));

    foreach (string taskName in taskNames)
        tasks.Add(new UserTask(taskName));

    Manager manager = new();

    manager.SendUsersTasks(
        new List<User>() { users[0], users[1] },
        new List<UserTask>() { tasks[0], tasks[1], tasks[2] }
    );
}
else
{
    Console.WriteLine("The JSON file does not exist.");
}







