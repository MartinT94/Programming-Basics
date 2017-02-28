using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumbers = Console.ReadLine();
            var secondNumbers = int.Parse(Console.ReadLine());

            var firstRev = Reversed(firstNumbers).ToCharArray();

            var sb = new StringBuilder();
            var result = 0;
            if (secondNumbers != 0)
            {
                for (int i = 0; i < firstRev.Length; i++)
                {
                    var temp1 = int.Parse(firstRev[i].ToString());

                    result += temp1 * secondNumbers;
                    var lastDigit = result % 10;
                    sb.Append(lastDigit);
                    result = result / 10;

                }

                if (result != 0)
                {
                    sb.Append(result);
                }

                var print = sb.ToString();
                Console.WriteLine(Reversed(print).TrimStart('0'));
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        public static string Reversed(string input)
        {
            var lettRev = input.ToCharArray();
            Array.Reverse(lettRev);
            return new string(lettRev);
        }
    }
}
