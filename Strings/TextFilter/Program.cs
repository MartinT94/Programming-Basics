using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new[] { ',' , ' '}, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            var sb = new StringBuilder(text);

            foreach (var word in bannedWords)
            {
                sb.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(sb);
            
        }
    }
}
