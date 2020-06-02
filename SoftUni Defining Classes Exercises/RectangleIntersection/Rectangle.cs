using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Point Coordinates { get; set; }
        public Rectangle(string id, double width, double height, Point coordinates)
        {
            ID = id;
            Width = Math.Abs(width);
            Height = Math.Abs(height);
            Coordinates = coordinates;
        }
        public static List<Rectangle> CreateRectangles(int number)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            for (int i = 1; i <= number; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Rectangle current = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]),
                    new Point(double.Parse(input[3]), double.Parse(input[4])));
                rectangles.Add(current);
            }
            return rectangles;
        }
        public static bool CheckIfIntersect(Rectangle first, Rectangle second)
        {
            if (first.Coordinates.X + first.Width >= second.Coordinates.X &&
                first.Coordinates.X <= second.Coordinates.X + second.Width &&
                first.Coordinates.Y >= second.Coordinates.Y - second.Height &&
                first.Coordinates.Y - first.Height <= second.Coordinates.Y)
                return true;
            else return false;
        }
    }
}
