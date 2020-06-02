using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRectangles = input[0];
            int numberOfIntersections = input[1];
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles = Rectangle.CreateRectangles(numberOfRectangles);
            for (int i = 1; i <= numberOfIntersections; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                int index1 = rectangles.FindIndex(x => x.ID == command[0]);
                int index2 = rectangles.FindIndex(x => x.ID == command[1]);
                Console.WriteLine(Rectangle.CheckIfIntersect(rectangles[index1], rectangles[index2]).ToString().ToLower());
            }
            Console.ReadLine();
        }
    }
}
