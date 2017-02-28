using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            var input = Console.ReadLine();

            var pattern = @"([^.!?]+)([\W])";

            var pattern1 = string.Format("\\b" + word + "\\b");
            
            var regex = new Regex(pattern);

            var keyWord = new Regex(pattern1);

            var matches = regex.Matches(input);

            

            foreach (Match match in matches)
            {
                if (keyWord.IsMatch(match.Groups[1].Value))
                {
                    Console.WriteLine(match.Groups[1].Value.Trim());
                }
               
            }
        }
    }
}
