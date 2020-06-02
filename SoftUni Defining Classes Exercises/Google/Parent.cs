using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Parent
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public Parent(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}
