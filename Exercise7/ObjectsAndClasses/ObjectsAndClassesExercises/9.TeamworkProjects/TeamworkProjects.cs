using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            var teamCount = int.Parse(Console.ReadLine());
            List<Team> teamAndCreator = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                Team currTeam = new Team();

                var teamText = Console.ReadLine()
                    .Split("-".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                var crator = teamText[0];
                var team = teamText[1];

                if (teamAndCreator.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }
                else if (teamAndCreator.Any(x => x.CreatorOfTeam == crator))
                {
                    Console.WriteLine($"{crator} cannot create another team!");
                    continue;
                }
                else
                {
                    currTeam.CreatorOfTeam = crator;
                    currTeam.Name = team;
                    currTeam.Members = new List<string>();
                    teamAndCreator.Add(currTeam);

                    Console.WriteLine($"Team {currTeam.Name} has been created by {currTeam.CreatorOfTeam}!");
                }
            }
          
            var members = new List<string>();

            while (true)
            {
                var userText = Console.ReadLine();
                if (userText.ToLower() == "end of assignment") break;

                var memberText = userText
                    .Split("->".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                Team currMember = new Team();

                var user = memberText[0];
                var team = memberText[1];

                if (teamAndCreator.All(x => x.Name != team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }

                    if (teamAndCreator.Any(x => x.Members.Contains(user)) || teamAndCreator.Any(x => x.CreatorOfTeam == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }

                int teamIndex = teamAndCreator.FindIndex(x => x.Name == team);
                teamAndCreator[teamIndex].Members.Add(user);

            }

            teamAndCreator = teamAndCreator.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var team in teamAndCreator)
            {
                if (team.Members.Count != 0)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine($"- {team.CreatorOfTeam}");

                    foreach (var memter in team.Members.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {memter}");
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            
            foreach (var disbandTeam in teamAndCreator.OrderBy(x => x.Name))
            {
                if (disbandTeam.Members.Count == 0)
                {
                    Console.WriteLine(disbandTeam.Name);
                }
            }
        }
    }
}
