using System;
using System.Linq;
using System.Text;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            if (text.Length == 20) result.Append(text);
            else if (text.Length < 20)
            {
                result.Append(text);
                result.Append(new string('*', 20 - text.Length));
            }
            else
            {
                result.Append(text.Substring(0, 20));
            }
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
