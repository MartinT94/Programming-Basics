using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runing = false;

            List<string> minerList = new List<string>();

            var dict = new Dictionary<string, int>();

            while (!runing)
            {
                string input = Console.ReadLine();
                minerList.Add(input);

                if (input == "stop")
                {
                    runing = true;
                }
                
            }
            for (int i = 0; i < minerList.Count - 1; i+= 2)
            {
                if (!dict.ContainsKey(minerList[i]))
                {
                    dict.Add(minerList[i], int.Parse(minerList[i + 1]));
                }
                else if (dict.ContainsKey(minerList[i]))
                {
                    dict[minerList[i]] += int.Parse(minerList[i + 1]);
                }
                
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
