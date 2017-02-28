using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    public class CirclesIntersection
    {
        public static void Main(string[] args)
        {
            var firstCirleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCirleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstCirle = new Point
            {
                X = firstCirleParts[0],
                Y = firstCirleParts[1],
            };

            var secondCirle = new Point
            {
                X = secondCirleParts[0],
                Y = secondCirleParts[1],
            };

            var firstRadius = new Cirlce
            {
                Radius = firstCirleParts[2]
            };
            var secondRadius = new Cirlce
            {
                Radius = secondCirleParts[2]
            };

            Console.WriteLine(IsIntersect(firstRadius , secondRadius , DistanceBetweenCirle(firstCirle , secondCirle)) ? "Yes" : "No");
        }

        public static double DistanceBetweenCirle(Point firstCirle , Point secondCirle)
        {
            var diffX = firstCirle.X - secondCirle.X;
            var diffY = firstCirle.Y - secondCirle.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }

        public static bool IsIntersect(Cirlce firstRadius , Cirlce secondRadius , double d)
        {
            if (firstRadius.Radius + secondRadius.Radius >= d)
                return true;
            return false;
        }
    }
}
