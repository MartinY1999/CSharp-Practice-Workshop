using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public static Rectangle Create()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            return new Rectangle(width, height);
        }
        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; i++)
            {
                DrawLine(this.Width, '*', ' ');
            }
            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
