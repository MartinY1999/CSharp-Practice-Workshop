using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public static Box CreateBox()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return new Box(length, width, height);
        }
        public double SurfaceArea()
        {
            return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
        }
        public double LateralSurfaceArea()
        {
            return 2 * (this.Length * this.Height + this.Width * this.Height);
        }
        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }
        public bool ValidateData()
        {
            if (Length <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
                return false;
            }
            else if (Width <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
                return false;
            }
            else if (Height <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
                return false;
            }
            else return true;
        }
    }
}
