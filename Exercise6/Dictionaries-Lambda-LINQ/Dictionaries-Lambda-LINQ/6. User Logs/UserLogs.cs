using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.User_Logs
{
    class UserLogs
    {
        static void Main()
        {

            var ipsDictionary = new Dictionary<string, int>();
            var userDictionary = new SortedDictionary<string, List<string>>();

            while (true)
            {
                var text = Console.ReadLine();
                var textToArray = text
                .Split("\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (textToArray[0] == "end") break;

                var ips = textToArray[0]
                    .Split('=');

                var messageText = textToArray[1]
                    .Split('=');

                var user = textToArray[2]
                    .Split('=');

                var IPs = new List<string>();
                IPs.Add(ips[1]);

                if (!userDictionary.ContainsKey(user[1]))
                {
                    userDictionary[user[1]] = IPs;
                }
                else
                {
                    userDictionary[user[1]].AddRange(IPs);
                }
            }
            foreach (var userName in userDictionary)
            {
                Console.WriteLine(userName.Key + ":");
                var ipsList = userName.Value;
                foreach (var ip in ipsList)
                {
                    if (!ipsDictionary.ContainsKey(ip))
                    {
                        ipsDictionary[ip] = 0;
                    }
                    ipsDictionary[ip] += 1;
                }
                var count = ipsDictionary.Count;
                foreach (var item in ipsDictionary)
                {
                    count--;
                    if (count > 0)
                    {
                        Console.WriteLine($"{item.Key} => {item.Value},");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Key} => {item.Value}.");
                    }
                }
            }
        }
    }
}