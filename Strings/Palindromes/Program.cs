using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == Reversed(input[i]))
                {
                    palindromes.Add(input[i]);
                }
            }
            

            Console.Write(string.Join(", ", palindromes.OrderBy(x => x).Distinct()));

        }

        public static string Reversed(string input)
        {
            var lettRev = input.ToCharArray();
            Array.Reverse(lettRev);
            return new string(lettRev);
        }
    }
}
