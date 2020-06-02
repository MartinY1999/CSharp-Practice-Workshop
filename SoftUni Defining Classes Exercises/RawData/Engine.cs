using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public int Power { get; set; }
        public int Speed { get; set; }
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
