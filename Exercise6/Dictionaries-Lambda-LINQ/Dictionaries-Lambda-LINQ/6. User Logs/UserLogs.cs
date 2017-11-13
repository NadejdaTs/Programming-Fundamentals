using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class UserLogs
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var textSplit = text
                .Split(' ','=');

            var usersAndIpAddresses = new Dictionary<string, List<string>>();
            var ipS = new List<string>();

            while (!text.Equals("end"))
            {
                var ip = textSplit[1];
                var user = textSplit[5];
                ipS.Add(ip);
                
                if (!usersAndIpAddresses.ContainsKey(user))
                {
                    usersAndIpAddresses[user] = ipS;
                }
                else
                {
                    usersAndIpAddresses[user].AddRange(ipS);
                }
                text = Console.ReadLine();
            }
            
            foreach (var user in usersAndIpAddresses)
            {
                Console.WriteLine(user+":");
                ipS = user.Value;

                var countOfIps = new Dictionary<string, int>();

                foreach (var ip in ipS)
                {
                    if (!countOfIps.ContainsKey(ip))
                    {
                        countOfIps[ip] = 1;
                    }
                    else
                    {
                        countOfIps[ip] += 1;
                    }
                }

                int ipCount = countOfIps.Count;

                foreach (var ip in countOfIps)
                {
                    ipCount--;
                    if (ipCount > 0)
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value},");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                }
                Console.WriteLine();               
            }
        }
    }
}
