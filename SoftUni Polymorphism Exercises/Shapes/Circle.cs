using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            private set { radius = value; }
        }
        public override double CalculatePerimeter() => 2 * Math.PI * this.Radius;
        public override double CalculateArea() => Math.PI * Math.Pow(this.Radius, 2);
        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
