using System;

namespace DependencyInversion.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(object toPrint)
        {
            Console.WriteLine(toPrint);
        }
    }
}
