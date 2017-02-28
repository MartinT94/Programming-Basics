using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrasis = new string[] {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                var phrasisIndex = random.Next(0, phrasis.Length - 1);
                var authorIndex = random.Next(0, author.Length - 1);
                var eventsIndex = random.Next(0, events.Length - 1);
                var citiesIndex = random.Next(0, cities.Length - 1);

                Console.WriteLine($"{phrasis[phrasisIndex]} {events[eventsIndex]} {author[authorIndex]} {cities[citiesIndex]}");
            }
        }
    }
}
