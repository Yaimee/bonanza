using UserSpace; // Assuming this is the correct namespace for your User class
using System.Text.Json;

namespace JsonParser
{
    class JsonUserParser
    {
        public static List<User> ReadUsersFromJson(string filename)
        {
            List<User> users = new List<User>();
            try
            {
                // Read the JSON file into a string
                string jsonString = File.ReadAllText(filename);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Deserialize the JSON string into a List of User objects
                Root root = JsonSerializer.Deserialize<Root>(jsonString, options) ?? new Root();
                if (root.users != null) // Ensure 'users' is not null before accessing it
                {
                    users = root.users;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return users; // Return the populated list of users
        }
    }
}
