using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(([\w+\.-])+\@[A-Za-z-]+)(\b\.[A-Za-z-]+)+";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var matchString = match.ToString();
                if (!(matchString.StartsWith(".") || matchString.StartsWith("_") || matchString.StartsWith("-")
                    || matchString.EndsWith(".") || matchString.EndsWith("_") || matchString.EndsWith("-")))
                {
                    Console.WriteLine(match);
                }
                
            }


        }
    }
}
