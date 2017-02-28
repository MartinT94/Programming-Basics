using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dict = new SortedDictionary<string, Dictionary<string, int>>();

            int counter = 1;

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '=', 'I', 'P', '&' }, StringSplitOptions.RemoveEmptyEntries);

                var ip = tokens[0];
                var userName = tokens[tokens.Length - 1];

                if (!dict.ContainsKey(userName))
                {
                    dict.Add(userName, new Dictionary<string, int>());
                    
                }
                if (!dict[userName].ContainsKey(ip))
                {
                    dict[userName].Add(ip, counter);
                }
                else
                {
                    dict[userName][ip]++;
                }
                
                input = Console.ReadLine();

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var adrres in item.Value)
                {
                    if (adrres.Key != item.Value.Keys.Last())
                    {
                        Console.Write($"{adrres.Key} => {adrres.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{adrres.Key} => {adrres.Value}. ");
                    }
                    
                }

            }

        }
    }
}
