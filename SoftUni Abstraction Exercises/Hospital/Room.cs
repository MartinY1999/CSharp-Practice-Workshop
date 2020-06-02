using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Room
    {
        public List<Patient> Patients { get; set; } = new List<Patient>(3);
    }
}
