using System;

namespace Farm
{
    public abstract class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
}
