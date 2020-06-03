using System;
using System.Linq;
using System.Reflection;

namespace CreateAttribute
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(Program);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            foreach (var methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.Any(x => x.AttributeType == typeof(SUAttribute)))
                {
                    var attrs = methodInfo.GetCustomAttributes(false);
                    foreach (SUAttribute attr in attrs)
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {attr.Name}");
                    }
                }
            }
        }
    }
}
