using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Doctor
    {
        public string FullName { get; set; } = string.Empty;
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public Doctor(string name)
        {
            FullName = name;
        }
        public static int IndexOfDoctor(List<Doctor> doctors, string fullName)
        {
            if (doctors.Any(x => x.FullName == fullName) == false)
            {
                Doctor currentDoc = new Doctor(fullName);
                doctors.Add(currentDoc);
                return doctors.FindIndex(x => x.FullName == fullName);
            }
            else
            {
                return doctors.FindIndex(x => x.FullName == fullName);
            }
        }
        public static void PrintPatients(List<Doctor> doctors, string fullName)
        {
            int index = doctors.FindIndex(x => x.FullName == fullName);
            foreach (Patient patient in doctors[index].Patients.OrderBy(x => x.Name))
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}
