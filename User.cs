using ToDoListApplication.Utils;

namespace ToDoListApplication
{
    public class User
    {
        private string _id;

        private string _name;

        private List<UserTask> _tasks;

        public User(string name, List<UserTask>? tasks = null)
        {
            Id = UniqueIdGenerator.GeterateUniqueId();
            Name = name;
            Tasks = tasks ?? new List<UserTask>();
        }

        public string Id
        {
            get { return _id; }
            set
            {
                if (value.Length != 8)
                    throw new Exception("Enter valid id");

                _id = value;
            }
        }

        public string Name 
        { 
            get { return _name; }
            set {
                if (value.Length > 15 && value.Length <= 1)
                    throw new Exception("Enter valid number");

                _name = value;
            } 
        }

        public List<UserTask> Tasks {
            get { 
                return _tasks; 
            }
            private set { 
                _tasks = value; 
            } 
        }

        public void ShowUserTasks()
        {
            Console.WriteLine();

            foreach (var task in Tasks)
            {
                Console.Write(task.Name, ", ");
            }

            Console.WriteLine();
        }
    }
}
