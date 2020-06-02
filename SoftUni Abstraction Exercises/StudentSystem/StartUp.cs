using System;

namespace StudentSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            System studentSystem = new System();
            while (true)
            {
                string input = Console.ReadLine();
                if (System.CheckIfExit(input)) break;
                else
                {
                    studentSystem = System.ExecuteCommand(input, studentSystem);
                }
            }
            Console.ReadLine();
        }
    }
}
