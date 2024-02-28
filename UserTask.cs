using ToDoListApplication.Utils;

namespace ToDoListApplication
{
    public class UserTask
    {
        private string _id;
        private string _name;
        private bool _isCompleted;

        public UserTask(string name, bool isCompleted = false)
        {
            Id = UniqueIdGenerator.GeterateUniqueId();
            Name = name;
            IsCompleted = isCompleted;
        }

        public string Id
        {
            get { return _id; }
            set {
                if (value.Length > 15)
                    throw new Exception("Enter valid id");
                
                _id = value; 
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value.Length > 50)
                    throw new Exception("Enter valid task name");

                _name = value;
            }
        }
    
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

    }
}
