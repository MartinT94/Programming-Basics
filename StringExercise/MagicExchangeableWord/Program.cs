using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstWord = words[0];
            var secondWord = words[1];

            Console.WriteLine(IsExchangeable(firstWord, secondWord) ? "true" : "false");


        }
        public static bool IsExchangeable(string firstWord, string secondWord)
        {
            var firstLetters = firstWord.ToCharArray();
            var secondLetters = secondWord.ToCharArray();
            var dict = new Dictionary<char, char>();

            bool isExchangeable = true;

            // First Case


            if (firstLetters.Length < secondLetters.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (!dict.ContainsKey(firstLetters[i]))
                    {
                        if (!dict.ContainsValue(firstLetters[i]))
                        {
                            dict.Add(firstLetters[i] ,secondLetters[i]);
                        }
                        else
                        {
                            isExchangeable = false;
                            break;
                        }
                    }
                    else
                    {
                        if (dict[firstLetters[i]] != secondLetters[i])
                        {
                            isExchangeable = false;
                            break;
                        }
                    }
                    

                }

                var diff = secondLetters.Length - firstLetters.Length;
                var checkLetters = new List<char>();


                for (int i = 0; i < secondLetters.Length - diff; i++)
                {
                    checkLetters.Add(secondLetters[i]);
                }

                for (int i = firstLetters.Length; i < secondLetters.Length; i++)
                {
                    if (!checkLetters.Contains(secondLetters[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
              

            }
            // Second Case

            else if (secondLetters.Length < firstLetters.Length)
            {
                for (int i = 0; i < secondLetters.Length; i++)
                {
                    if (!dict.ContainsKey(secondLetters[i]))
                    {
                        dict[secondLetters[i]] = new List<char>();
                    }
                    if (dict.ContainsKey(secondLetters[i]))
                    {
                        dict[secondLetters[i]].Add(firstLetters[i]);
                    }

                }

                foreach (var letter in dict)
                {
                    for (int j = 1; j < letter.Value.Count; j++)
                    {
                        if (letter.Value[j] != letter.Value[j - 1])
                        {
                            isExchangeable = false;
                            break;
                        }
                    }
                }

                var diff = firstLetters.Length - secondLetters.Length;
                var checkLetters = new List<char>();
                for (int i = 0; i < firstLetters.Length - diff; i++)
                {
                    checkLetters.Add(firstLetters[i]);
                }
                for (int i = secondLetters.Length; i < firstLetters.Length; i++)
                {
                    if (!checkLetters.Contains(firstLetters[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            //Third Case
            else
            {
                for (int i = 0; i < firstLetters.Length; i++)
                {
                    if (!dict.ContainsKey(firstLetters[i]))
                    {
                        dict[firstLetters[i]] = new List<char>(); 
                    }
                    if (dict.ContainsKey(firstLetters[i]))
                    {
                        dict[firstLetters[i]].Add(secondLetters[i]);
                    }
                }

                foreach (var letter in dict)
                {
                    for (int j = 1; j < letter.Value.Count; j++)
                    {
                        if (letter.Value[j] != letter.Value[j - 1])
                        {
                            isExchangeable = false;
                            break;
                        }
                    }

                }
            }

            return isExchangeable;

        }
    }
}
