using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Department
    {
        public string Name { get; set; } = string.Empty;
        public List<Room> Rooms { get; set; } = new List<Room>();
        public Department(string name)
        {
            Name = name;
            for (int i = 0; i < 20; i++)
            {
                Rooms.Add(new Room());
            }
        }
        public static int ReturnDepartmentIndex(List<Department> departments, string nameOfDepartment)
        {
            if (departments.Any(x => x.Name == nameOfDepartment) == false)
            {
                Department current = new Department(nameOfDepartment);
                departments.Add(current);
                return departments.FindIndex(x => x.Name == nameOfDepartment);
            }
            else
            {
                return departments.FindIndex(x => x.Name == nameOfDepartment);
            }
        }
        public bool CheckIfEnoughSpace()
        {
            return Rooms.SelectMany(x => x.Patients).Count() < 60;
        }
        public static int IndexOfRoomWithFreeSpaces(Department current)
        {
            int room = 0;
            for (int i = 0; i < current.Rooms.Count; i++)
            {
                if (current.Rooms[i].Patients.Count < 3)
                {
                    room = i;
                    break;
                }
            }
            return room;
        }
        public static void PrintWholeDepartment(List<Department> departments, string name)
        {
            int index = departments.FindIndex(x => x.Name == name);
            foreach (Room room in departments[index].Rooms.Where(x => x.Patients.Count > 0))
            {
                foreach (Patient roomPatient in room.Patients)
                {
                    Console.WriteLine(roomPatient.Name);
                }
            }
        }
        public static void PrintExactRoom(List<Department> departments, string[] parts)
        {
            string name = parts[0];
            int indexOfRoom = int.Parse(parts[1]) - 1;
            int indexOfDep = departments.FindIndex(x => x.Name == name);
            foreach (Patient patient in departments[indexOfDep].Rooms[indexOfRoom].Patients.OrderBy(x => x.Name))
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}
