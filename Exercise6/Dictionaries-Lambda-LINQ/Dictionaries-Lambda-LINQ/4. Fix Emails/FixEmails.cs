using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Fix_Emails
{
    class FixEmails
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var emailAddresses = new Dictionary<string, string>();
            while (text != "stop")
            {
                var name = text;
                var email = Console.ReadLine();
                if (!emailAddresses.ContainsKey(name))
                {
                    emailAddresses[name] = "";
                }
                emailAddresses[name] += email;

                text = Console.ReadLine();
            }

            var fixedEmail = emailAddresses
                .Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk"))
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var email in fixedEmail)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
