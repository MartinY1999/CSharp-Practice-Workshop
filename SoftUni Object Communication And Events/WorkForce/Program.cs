using WorkForce.Controller;
using WorkForce.Factories;
using WorkForce.IO;
using WorkForce.Models;

namespace WorkForce
{
    public class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            Executioner executioner = new Executioner(new JobFactory(),
                new EmployeeFactory(), writer);
            JobCentre jobCentre = new JobCentre();
            Engine engine = new Engine(reader, executioner, jobCentre);
            engine.Run();
        }
    }
}
