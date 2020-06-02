using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        public int Radius { get; private set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public static Circle Create()
        {
            int radius = int.Parse(Console.ReadLine());
            return new Circle(radius);
        }
        public void Draw()
        {
            double radiusIn = this.Radius - 0.4;
            double radiusOut = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < radiusOut; x += 0.5)
                {
                    double value = Math.Pow(x, 2) + Math.Pow(y, 2);
                    if (value >= Math.Pow(radiusIn, 2) && value <= Math.Pow(radiusOut, 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
