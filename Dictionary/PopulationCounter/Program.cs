using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var countrys = new Dictionary<string, Dictionary<string, long>>();
            while (line != "report")
            {
                var data = line.Split('|');
                
                var citys = data[0];
                var country = data[1];
                var population = int.Parse(data[2]);

                if (!countrys.ContainsKey(country))
                {
                    countrys[country] = new Dictionary<string, long>();
                }
                if (countrys.ContainsKey(country))
                {
                    countrys[country].Add(citys, population);
                }
                
                line = Console.ReadLine();

            }

            
            foreach (var city in countrys.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var sum = city.Value.Values.Sum();
                
                Console.WriteLine($"{city.Key} (total population: {sum})");

                foreach (var item in city.Value.OrderByDescending(k => k.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }
        }
    }
}
