using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UserSpace;
namespace XmlParser
{
    class XmlUserParser
    {
        public static List<User> ReadUsersFromXml(string filename)
        {
            XDocument doc = XDocument.Load(filename);
            var users = doc.Descendants("user")
                           .Select(user => new User(
                               int.Parse(user.Element("user_id")?.Value),
                               user.Element("name").Value,
                               user.Element("email").Value))
                           .ToList();
            return users;
        }
    }
}