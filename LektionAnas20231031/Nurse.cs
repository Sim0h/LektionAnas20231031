using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LektionAnas20231031
{
    internal class Nurse : Person
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        public static void BloodSample()
        {
            Console.WriteLine("Nurse is allowed to take a bloodsample.");
        }

    }
}
