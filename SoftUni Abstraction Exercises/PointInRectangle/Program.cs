using System;

namespace PointInRectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Rectangle.ParseCoordinates();
            Rectangle mainRectangle = Rectangle.CreateRectangle(coordinates);
            int numberOfPoints = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfPoints; i++)
            {
                int[] currentPointCoordinates = Rectangle.ParseCoordinates();
                Point currentPoint = Point.CreatePoint(currentPointCoordinates);
                Rectangle.PrintResult(mainRectangle.Contains(currentPoint));
            }
            Console.ReadLine();
        }
    }
}
