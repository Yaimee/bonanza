using System;

namespace UserSpace // Replace with your actual namespace
{
    public class Root
    {
        public List<User> users { get; set; } = new List<User>();
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Ensure this constructor is public
        public User() { }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void PrintUser()
        {
            Console.WriteLine($"UserID: {Id}, Name: {Name}, Email: {Email}");
        }
    }
}
