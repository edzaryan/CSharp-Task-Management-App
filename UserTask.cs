using ToDoListApplication.Utils;

namespace ToDoListApplication
{
    public class UserTask
    {
        private string _name;
        private bool _isCompleted;

        public UserTask(string? name, bool isCompleted = false)
        {
            Id = UniqueIdGenerator.GeterateUniqueId();
            Name = name;
            IsCompleted = isCompleted;
        }

        public string? Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new Exception("Enter value for the name");
                }

                if (value.Length > 50) {
                    throw new Exception("Enter valid task name");
                }

                _name = value;
            }
        }
    
        public string Id { get; }
        public bool IsCompleted { get; set; }

    }
}
