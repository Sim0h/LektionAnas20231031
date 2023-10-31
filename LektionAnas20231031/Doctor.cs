using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LektionAnas20231031
{
    internal class Doctor : Person
    {
        public int Salary { get; set; }
        public double Workhours { get; set; }

        public static void WritePrescription()
        {
            Console.WriteLine("The doctor is allowed to write a prescription.");
        }

    }
}
