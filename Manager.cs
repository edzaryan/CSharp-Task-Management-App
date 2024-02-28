
namespace ToDoListApplication
{
    public class Manager
    {
        public void SendUsersTasks(List<User> users, List<UserTask> tasks)
        {
            foreach (var user in users)
            {
                user.Tasks.AddRange(new List<UserTask>(tasks));
            }
        }

        public void RemoveTask(User user, string taskId)
        {
            if (!user.Tasks.Any(task => task.Id == taskId))
                throw new Exception("No task with the specified taskId was found.");

            user.Tasks.RemoveAll(task => task.Id == taskId);
        }

        public void UpdateTask(User user, string taskId, string newTitle)
        {
            var taskToUpdate = user.Tasks.First(task => task.Id == taskId);

            taskToUpdate.Name = newTitle;
        }
    }
}
