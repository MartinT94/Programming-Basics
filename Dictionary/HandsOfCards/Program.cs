using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardPowers = GetCardsPowers();
            var cardTypes = GetCardsTypes();

            var line = Console.ReadLine();
            var cards = new Dictionary<string, HashSet<int>>();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');

                var name = tokens[0];
                var playersCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playersCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }


                    cards[name].Add(sum);

                }

                line = Console.ReadLine();
            }

            foreach (var player in cards)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }
        }

        private static Dictionary<string , int> GetCardsTypes()
        {
            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;
        }

        private static Dictionary<string , int> GetCardsPowers()
        {
            var powers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }
    }
}
