using System;
using System.Collections.Generic;

namespace Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Doctor> doctors = new List<Doctor>();
            List<Department> departments = new List<Department>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Output") break;
                else
                {
                    string[] splitString = SplitString(input);
                    Patient currentPatient = new Patient(splitString[3]);
                    int indexOfDoc = Doctor.IndexOfDoctor(doctors, splitString[1] + " " + splitString[2]);
                    int indexOfDep = Department.ReturnDepartmentIndex(departments, splitString[0]);
                    if (departments[indexOfDep].CheckIfEnoughSpace())
                    {
                        doctors[indexOfDoc].Patients.Add(currentPatient);
                        int freeRoomIndex = Department.IndexOfRoomWithFreeSpaces(departments[indexOfDep]);
                        departments[indexOfDep].Rooms[freeRoomIndex].Patients.Add(currentPatient);
                    }
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    string[] splitStrings = SplitString(input);
                    if (splitStrings.Length == 1)
                        Department.PrintWholeDepartment(departments, splitStrings[0]);
                    else if (splitStrings.Length == 2 && int.TryParse(splitStrings[1], out int value))
                        Department.PrintExactRoom(departments, splitStrings);
                    else 
                        Doctor.PrintPatients(doctors, splitStrings[0] + " " + splitStrings[1]);
                }
            }
            Console.ReadLine();
        }
        private static string[] SplitString(string input)
        {
            return input.Split(' ');
        }
    }
}
