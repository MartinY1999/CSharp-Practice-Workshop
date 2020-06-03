using System.Linq;
using System.Reflection;
using Autofac;
using DependencyInversion.Calculators;
using DependencyInversion.Calculators.Contract;
using DependencyInversion.Controller;
using DependencyInversion.IO;
using DependencyInversion.Strategies.Changer;
using DependencyInversion.Strategies.Contract;

namespace DependencyInversion
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Engine>().AsSelf();
            builder.RegisterType<PrimitiveCalculator>().As<ICalculator>();
            builder.RegisterType<Reader>().As<IReader>();
            builder.RegisterType<Writer>().As<IWriter>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInversion)))
                .Where(x => x.Namespace.Contains("Strategies"))
                .As<IStrategy>();

            return builder.Build();
        }
    }
}
