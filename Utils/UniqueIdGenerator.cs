
namespace ToDoListApplication.Utils
{
    public static class UniqueIdGenerator
    {
        private static Random random = new Random();
        private const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string GeterateUniqueId(int length = 8)
        {
            char[] uniqueId = new char[length];

            for (int i=0; i < length; i++)
            {
                uniqueId[i] = characters[random.Next(characters.Length)];
            }

            return new string(uniqueId);
        }
    }
}
