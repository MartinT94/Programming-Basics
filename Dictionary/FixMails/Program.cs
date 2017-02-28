using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixMails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameAndMails = new List<string>();

            var dict = new Dictionary<string, string>();

            bool runinng = false;

            while (!runinng)
            {
                string input = Console.ReadLine();
                nameAndMails.Add(input);

                if (input == "stop")
                {
                    runinng = true;
                }
            }

            for (int i = 0; i < nameAndMails.Count; i++)
            {
                if (nameAndMails[i].Contains(".us") || nameAndMails[i].Contains(".uk"))
                {
                    nameAndMails.RemoveAt(i);
                    nameAndMails.RemoveAt(i - 1);
                }
            }

            for (int i = 0; i < nameAndMails.Count - 1; i+= 2)
            {
                if (!dict.ContainsKey(nameAndMails[i]))
                {
                    dict.Add(nameAndMails[i], nameAndMails[i + 1]);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
