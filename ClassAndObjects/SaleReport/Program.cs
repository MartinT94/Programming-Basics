using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(' ');

                var sale = new Sale
                {
                    Town = line[0],
                    Product = line[1],
                    Quantity = decimal.Parse(line[2]),
                    Price = decimal.Parse(line[3])
                };

                if (!dict.ContainsKey(sale.Town))
                {
                    dict[sale.Town] = 0;
                }

                dict[sale.Town] += sale.Quantity * sale.Price;

               }

            foreach (var town in dict)
            {
                Console.WriteLine("{0} -> {1:f2}" , town.Key , town.Value);
            }


        }
    }
}
