using System;

namespace WorkForce.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(object element)
        {
            Console.WriteLine(element);
        }
    }
}
