using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using UserSpace; // Assuming this is the correct namespace for your User class

namespace CsvParser
{
    class CsvUserParser
    {
        public static List<User> ReadUsersFromCsv(string filename)
        {
            List<User> users = new List<User>();
            try
            {
                StreamReader sr = new StreamReader(filename);
                sr.ReadLine(); // Skip the header line
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var parts = line?.Split(',');
                    if (parts != null && parts.Length == 3) // sikrer at der er 3 dele
                    {
                        int userId;
                        if (int.TryParse(parts[0], out userId)) // parser string til int
                        {
                            var user = new User(userId, parts[1], parts[2]);
                            users.Add(user);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid user ID format: {parts[0]}");
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return users; // Return the populated list of users
        }
    }
}
