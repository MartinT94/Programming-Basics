using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.Write(GetEscapeSequence(letter));
            }
            
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
