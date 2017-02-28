using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine();
            var secondNumbers = Console.ReadLine();

            var firstRev = Reversed(firstNumbers).ToCharArray();
            var secondRev = Reversed(secondNumbers).ToCharArray();

            var maxLenth = Math.Max(firstRev.Length, secondRev.Length);

            var sb = new StringBuilder();
            var sum = 0;

            for (int i = 0; i < maxLenth; i++)
            {
                var temp1 = 0;
                var temp2 = 0;

                if (i < firstRev.Length)
                {
                    temp1 = int.Parse(firstRev[i].ToString());
                }
                if (i < secondRev.Length)
                {
                    temp2 = int.Parse(secondRev[i].ToString());
                }
                sum += temp1 + temp2;
                var lastDigit = sum % 10;
                sb.Append(lastDigit);
                sum = sum / 10;

            }

            if (sum != 0)
            {
                sb.Append(sum);
            }

            var result = sb.ToString();
            Console.WriteLine(Reversed(result).TrimStart('0'));
        }
        public static string Reversed(string input)
        {
            var lettRev = input.ToCharArray();
            Array.Reverse(lettRev);
            return new string(lettRev);
        }
    }
}

