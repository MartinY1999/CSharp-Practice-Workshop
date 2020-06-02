using System;
using System.Linq;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public static int[] ParseCoordinates()
        {
            string input = Console.ReadLine();
            return input.Split(' ').Select(int.Parse).ToArray();
        }
        public static Rectangle CreateRectangle(int[] coordinates)
        {
            return new Rectangle(new Point(coordinates[0], coordinates[1]), new Point(coordinates[2], coordinates[3]));
        }
        public bool Contains(Point currentPoint)
        {
            bool isInHorizontal = TopLeft.X <= currentPoint.X &&
                                  BottomRight.X >= currentPoint.X;
            bool isInVertical = TopLeft.Y <= currentPoint.Y &&
                                BottomRight.Y >= currentPoint.Y;
            return isInHorizontal && isInVertical;
        }
        public static void PrintResult(bool statement)
        {
            if (statement) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
