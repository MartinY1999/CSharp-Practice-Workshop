using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Car
    {
        public string Model = string.Empty;
        public double Speed = 0;
        public Car() { }
        public Car(string model, double speed)
        {
            Model = model;
            Speed = speed;
        }
    }
}
