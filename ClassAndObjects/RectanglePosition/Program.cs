using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var secondRectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstRecrangle = new Rectangle
            {
                Left = firstRectangleParts[0],
                Top = firstRectangleParts[1],
                Width = firstRectangleParts[2],
                Height = firstRectangleParts[3]
            };

            var secondRecrangle = new Rectangle
            {
                Left = secondRectangleParts[0],
                Top = secondRectangleParts[1],
                Width = secondRectangleParts[2],
                Height = secondRectangleParts[3]
            };

            Console.WriteLine(IsInside(firstRecrangle , secondRecrangle) ? "Inside" : "Not inside");
        }

        public static bool IsInside(Rectangle first , Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var topIsCorrect = first.Top <= second.Top;
            var bottomIsCorrect = first.Bottom >= second.Bottom;

            return leftIsCorrect &&
                rightIsCorrect &&
                topIsCorrect &&
                bottomIsCorrect;
        }
    }
}
