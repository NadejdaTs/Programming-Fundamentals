using System;
using System.Collections.Generic;
using System.Linq;
 
class User_Logs
{
    static void Main(string[] args)
    {
        var users = new SortedDictionary<string, List<string>>();
        string command = "";
        while (true)
        {
            var entry = Console.ReadLine().Split().ToList();
            command = entry[0];
            if (command == "end") break;
            int indexOfIP = command.IndexOf('=') + 1;
            string ip = command.Substring(indexOfIP);
            int indexOfUser = entry[2].LastIndexOf('=') + 1;
            string user = entry[2].Substring(indexOfUser);
            var IPs = new List<string>();
            IPs.Add(ip);
            if (!users.ContainsKey(user))
            {
                users[user] = IPs;
            }
            else
            {
                users[user].AddRange(IPs);
            }
        }

        foreach (var user in users)
        {
            Console.WriteLine(user.Key + ": ");
            var IPs = user.Value;
            var numberOfIPs = new Dictionary<string, int>();
            foreach (var ip in IPs)
            {
                if (!numberOfIPs.ContainsKey(ip))
                {
                    numberOfIPs[ip] = 1;
                }
                else
                {
                    numberOfIPs[ip] += 1;
                }
            }

            int count = numberOfIPs.Count;
            foreach (var ip in numberOfIPs)
            {
                count--;
                if (count > 0)
                {
                    Console.WriteLine(ip.Key + " => " + ip.Value + ", ");
                }
                else
                {
                    Console.WriteLine(ip.Key + " => " + ip.Value + ". ");
                }
            }
            Console.WriteLine();
        }
    }
}
