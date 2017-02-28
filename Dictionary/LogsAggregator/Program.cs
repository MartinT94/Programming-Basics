using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                var ip = line[0];
                var userName = line[1];
                var counts = int.Parse(line[2]);

                if (!logs.ContainsKey(userName))
                {
                    logs[userName] = new SortedDictionary<string, int>();
                }
                if (!logs[userName].ContainsKey(ip))
                {
                    logs[userName].Add(ip, counts);
                }
                else
                {
                    logs[userName][ip] += counts;
                }

            }

            foreach (var user in logs)
            {
                sum = user.Value.Values.Sum();

                Console.Write($"{user.Key}: {sum} ");
                foreach (var item in user.Value)
                {
                    if (item.Key == user.Value.Keys.First() && item.Key == user.Value.Keys.Last())
                    {
                        Console.WriteLine($"[{item.Key}] ");
                    }
                    else
                    {
                        if (item.Key == user.Value.Keys.First())
                        {
                            Console.Write($"[{item.Key}, ");
                        }
                        else if (item.Key == user.Value.Keys.Last())
                        {
                            Console.WriteLine($"{item.Key}] ");
                        }
                        else
                        {
                            Console.Write($"{item.Key}, ");
                        }
                    }
                    
                    
                    
                }
            }
        }
    }
}
