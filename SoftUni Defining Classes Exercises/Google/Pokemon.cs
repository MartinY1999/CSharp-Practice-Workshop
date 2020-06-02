using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
