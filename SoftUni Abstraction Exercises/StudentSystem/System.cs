using System;
using System.Collections.Generic;

namespace StudentSystem
{
    public class System
    {
        public Dictionary<string, Student> Repository { get; set; }
        public System()
        {
            Repository = new Dictionary<string, Student>();
        }
        public static bool CheckIfExit(string input)
        {
            if (input == "Exit") return true;
            else return false;
        }
        public static System ExecuteCommand(string input, System repository)
        {
            string[] args = input.Split(' ');
            switch (args[0])
            {
                case "Create":
                    System.CreateStudent(args, repository);
                    break;
                case "Show":
                    repository.ShowStudentData(args);
                    break;
                default:
                    break;
            }
            return repository;
        }
        public static System CreateStudent(string[] args, System repository)
        {
            string name = args[1];
            int age = int.Parse(args[2]);
            double grade = double.Parse(args[3]);
            if (!repository.Repository.ContainsKey(name))
            {
                Student student = new Student(name, age, grade);
                repository.Repository[name] = student;
            }
            return repository;
        }
        public void ShowStudentData(string[] args)
        {
            string name = args[1];
            if (Repository.ContainsKey(name))
            {
                Student student = Repository[name];
                string view = $"{student.Name} is {student.Age} years old.";
                if (student.Grade >= 5.00)
                {
                    view += " Excellent student.";
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    view += " Average student.";
                }
                else
                {
                    view += " Very nice person.";
                }
                Console.WriteLine(view);
            }
        }
    }
}
