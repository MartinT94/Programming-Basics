using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            var firstWord = words[0];
            var secondWord = words[1];

            Console.WriteLine(GetSumOfChar(firstWord, secondWord));

        }

        public static BigInteger GetSumOfChar(string firstWord , string secondWord)
        {
            var firstLetters = firstWord.ToCharArray();
            var secondLetters = secondWord.ToCharArray();

            BigInteger sum = 0;

            if (firstLetters.Length < secondLetters.Length)
            {
                
                for (int i = 0; i < firstLetters.Length; i++)
                {
                    sum += firstLetters[i] * secondLetters[i];
                }

                for (int i = firstLetters.Length; i < secondLetters.Length; i++)
                {
                    sum += secondLetters[i];
                }
            }
            else if (secondLetters.Length < firstLetters.Length)
            {
                
                for (int i = 0; i < secondLetters.Length; i++)
                {
                    sum += firstLetters[i] * secondLetters[i];
                }

                for (int i = secondLetters.Length; i < firstLetters.Length; i++)
                {

                    sum += firstLetters[i];
                }
            }
            else
            {
                for (int i = 0; i < firstLetters.Length; i++)
                {
                    sum += firstLetters[i] * secondLetters[i];
                }
            }

            return sum;
        }
    }
}
