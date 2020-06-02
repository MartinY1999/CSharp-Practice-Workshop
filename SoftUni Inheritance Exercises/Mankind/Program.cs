using System;

namespace Mankind
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = Student.CreateStudent();
                Worker worker = Worker.CreateWorker();
                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
                Console.ReadLine();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
