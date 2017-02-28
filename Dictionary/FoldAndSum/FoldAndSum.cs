using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    public class FoldAndSum
    {
         public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = input.Length / 4;

            var leftRow =
                input.Take(k)
                .Reverse()
                .ToArray();

            var rightRow =
                input
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = leftRow
                .Concat(rightRow)
                .ToArray();

            var middle = input
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            var sum = firstRow.Select((x, index) => x + middle[index]);

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
