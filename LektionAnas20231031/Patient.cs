using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LektionAnas20231031
{
    internal class Patient : Person
    {
        public string Disease {  get; set; }
        public double TimeOfReg {  get; set; }
        public double TimeOfRelease { get; set; }
        public int missbruk {  get; set; }

        public static void Prescriptions()
        {
            if (Prescriptions > 0)
            {
                Console.WriteLine("Patient has {0} number of prescriptions.");
                
            }
            else
            {
               Console.WriteLine("Patient has no current prescriptions.");
               
            }
        }

    }
}
