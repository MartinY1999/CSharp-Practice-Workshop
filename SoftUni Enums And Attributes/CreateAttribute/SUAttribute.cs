using System;

namespace CreateAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SUAttribute : Attribute
    {
        public string Name { get; private set; }

        public SUAttribute(string name)
        {
            this.Name = name;
        }
    }
}
