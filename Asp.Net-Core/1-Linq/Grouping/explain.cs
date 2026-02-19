using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>
            {
                new Team{Name="perspolis",Country="Iran"},
                new Team{Name="Esteghlal",Country="Iran"},
                new Team{Name="Psg",Country="France"},
                new Team{Name="Arsenal",Country="England"},
                new Team{Name="Everton",Country="England"},
                new Team{Name="Manchester City",Country="England"},
            };

            //var result = teams.GroupBy(c => c.Country); --> GroupBy <--

            //var result = teams.ToLookup(c => c.Country); --> ToLookup <--

            //Notes: diffrent of ToLookup and GroupBy --> ToLookup is immediate execution and GroupBy is deffered execution

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var name in item)
                {
                    Console.WriteLine($"       {name.Name}");
                }
            }

            Console.ReadKey();
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
