using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRuning = false;

            var phoneBook = new SortedDictionary<string, string>();

            var sortedPhoneBook = new SortedDictionary<string, string>();

            while (!isRuning)
            {
                string[] input = Console.ReadLine()
                   .Split(' ')
                   .ToArray();

                string command = input[0];

                if (command == "END")
                {
                    isRuning = true;
                }
                if (command == "A")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook.Add(input[1], input[2]);
                    }
                    else if (!phoneBook.ContainsValue(input[2]))
                    {
                        phoneBook[input[1]] = input[2];
                    }
                }
                if (command == "S")
                {

                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }

                    foreach (var item in phoneBook)
                    {
                        if (input[1] == item.Key)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }

                }
                if (command == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
