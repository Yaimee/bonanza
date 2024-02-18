using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;
using UserSpace; // Assuming this is the correct namespace for your User class
using YamlDotNet.Serialization.NamingConventions;

namespace YamlParser
{
    class YamlUserParser
    {
        public static List<User> ReadUsersFromYaml(string filename)
        {
            List<User> users = new List<User>();
            try
            {
                // Read the YAML file into a string
                var sr = new StreamReader(filename);
                string yamlString = sr.ReadToEnd();
                sr.Close();

                // Deserialize
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(UnderscoredNamingConvention.Instance)
                    .Build();

                var root = deserializer.Deserialize<Root>(yamlString);
                if (root.users != null) // Ensure 'users' is not null before accessing it
                {
                    users = root.users;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
                if (e.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {e.InnerException.Message}");
                }
            }
            return users; // Return the populated list of users
        }
    }
}
