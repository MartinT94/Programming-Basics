using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPoints
{
    public class DistanceBetweenTwoPoints
    {
        public static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new Point
            {
                X = firstLine[0],
                Y = firstLine[1]
            };

            var secondLine = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new Point
            {
                X = secondLine[0],
                Y = secondLine[1]
            };

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine("{0:f3}" , result);
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
