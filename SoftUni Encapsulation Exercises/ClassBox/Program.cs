using System;

namespace ClassBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box box = Box.CreateBox();
            if (box.ValidateData())
            {
                Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.Volume():F2}");
            }
            Console.ReadLine();
        }
    }
}
