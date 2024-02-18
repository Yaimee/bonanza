using System;
using CsvParser;
using TxtParser;
using JsonParser;
using UserSpace;
using XmlParser;
using YamlParser;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<User> list = CsvUserParser.ReadUsersFromCsv("../files/file3.csv");
        List<User> list2 = TxtUserParser.ReadUsersFromTxt("../files/file1.txt");
        List<User> list3 = JsonUserParser.ReadUsersFromJson("../files/file4.json");
        List<User> list4 = XmlUserParser.ReadUsersFromXml("../files/file5.xml");
        List<User> list5 = YamlUserParser.ReadUsersFromYaml("../files/file2.yaml");
        System.Console.WriteLine("CSV:");
        foreach (User user in list)
        {
            user.PrintUser();
        }
        System.Console.WriteLine("TXT:");
        foreach (User user in list2)
        {
            user.PrintUser();
        }
        System.Console.WriteLine("JSON:");
        foreach (User user in list3)
        {
            user.PrintUser();
        }
        System.Console.WriteLine("XML:");
        foreach (User user in list4)
        {
            user.PrintUser();
        }
        System.Console.WriteLine("YAML:");
        foreach (User user in list5)
        {
            user.PrintUser();
        }
    }
}
