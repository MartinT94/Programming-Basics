using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWokrPoject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine().Trim();

            var teams = new List<Team>();

            while (!input.Equals("end of assignment"))
            {
                if (!input.Contains("->"))
                {
                    for (int i = 0; i < n; i++)
                    {
                        var creatTeamSeparators = input.Split('-');
                        var creatorName = creatTeamSeparators[0];
                        var teamName = creatTeamSeparators[1];

                        if (teams.Any(x => x.TeamName == teamName))
                        {
                            Console.WriteLine($"Team {teamName} was already created!");
                        }
                        else if (teams.Any(x => x.CreatorName == creatorName))
                        {
                            Console.WriteLine($"{creatorName} cannot create another team!");
                        }
                        else
                        {
                            var team = new Team();
                            team.TeamName = teamName;
                            team.CreatorName = creatorName;
                            teams.Add(team);
                            Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                        }


                        input = Console.ReadLine();
                    }
                }
                if (input == "end of assignment")
                {
                    break;
                }
                var memberTeam = new Team();

                var joinTeamSeparators = input.Split(new char[] { '-', '>' } , StringSplitOptions.RemoveEmptyEntries);
                var member = joinTeamSeparators[0];
                var teamToJoin = joinTeamSeparators[1];

                if (teams.Any(x => x.TeamName == teamToJoin) && teams.Any(x => x.CreatorName == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }
                else if (!teams.Any(x => x.TeamName == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }
                else
                {
                    if (teams.Any(x => x.TeamName == teamToJoin))
                    {
                        memberTeam = teams.First(x => x.TeamName == teamToJoin);
                        memberTeam.Members.Add(member);
                        memberTeam.Members.Sort();
                    }
                }

                input = Console.ReadLine();
            }
            
            foreach (var team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                if (team.Members.Count != 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.CreatorName}");
                    foreach (var memeber in team.Members)
                    {
                        Console.WriteLine($"-- {memeber}");
                    }
                }
                
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var team in teams.OrderBy(x => x.TeamName))
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine($"{team.TeamName}");
                }
            }
        }
    }
    class Team
    {
        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }

        public Team()
        {
            this.Members = new List<string>();
        }

    }
}
