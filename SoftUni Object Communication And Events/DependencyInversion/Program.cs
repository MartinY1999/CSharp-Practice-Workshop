using System;
using Autofac;
using DependencyInversion.Controller;

namespace DependencyInversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ContainerConfig.Configure();
            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                Engine app = scope.Resolve<Engine>();
                app.Run();
            }
            Console.ReadLine();
        }
    }
}
