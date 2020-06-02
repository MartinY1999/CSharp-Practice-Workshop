using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = Circle.Create();
            Rectangle rectangle = Rectangle.Create();
            circle.Draw();
            rectangle.Draw();
            Console.ReadLine();
        }
    }
}
