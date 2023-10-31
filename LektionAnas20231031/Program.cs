using System.Reflection.Metadata.Ecma335;

namespace LektionAnas20231031
{
    internal class Program
    {
        public List<Patient> patientList = new List<Patient>();

        static void Main(string[] args)
        {

            // Övning Queue<>
            Console.WriteLine("Employee List: ");
            Doctors();
            Nurses();

            Console.WriteLine("Patient List");
            Patients();
            



        }

        public static void Doctors() 
        {
            Doctor doc1 = new Doctor();
            doc1.FirstName = "David";
            doc1.LastName = "Johansson";
            doc1.Title = "Doctor";
            doc1.Salary = 100000;
            doc1.Workhours = 12;

            Doctor doc2 = new Doctor();
            doc2.FirstName = "Erik";
            doc2.LastName = "Andersson";
            doc2.Title = "Head Doctor";
            doc2.Salary = 120000;
            doc2.Workhours = 12;

            List<Doctor> Doctors = new List<Doctor>();
            Doctors.Add(doc1);
            Doctors.Add(doc2);

            foreach (Doctor item in Doctors)
            {
                Console.WriteLine("{0} {1}\nTitle: {2}\nSalary = {3}kr\nWorkhours: {4}", item.FirstName, item.LastName, item.Title, item.Salary, item.Workhours);
                Doctor.WritePrescription();
                Console.WriteLine();
            }
            

        }


        public static void Nurses()
        {
            Nurse Nurse1 = new Nurse();
            Nurse1.FirstName = "Andrea";
            Nurse1.LastName = "Jansson";
            Nurse1.Title = "Nurse";
            Nurse1.Salary = 30000;
            Nurse1.Gender = "Woman";
            Nurse1.Age = 30;

            Nurse Nurse2 = new Nurse();
            Nurse2.FirstName = "Britt-Marie";
            Nurse2.LastName = "Hedin";
            Nurse2.Title = "Nurse";
            Nurse2.Salary = 33000;
            Nurse2.Gender = "Woman";
            Nurse2.Age = 56;

            List<Nurse> nurses = new List<Nurse>();
            nurses.Add(Nurse1);
            nurses.Add(Nurse2);

            foreach (Nurse item in nurses)
            {
                Console.WriteLine("{0} {1}\nTitle: {2}\nSalary = {3}kr\nGender: {4}\nAge = {5} ", item.FirstName, item.LastName, item.Title, item.Salary, item.Gender, item.Age);
                Nurse.BloodSample();
                Console.WriteLine();
            }

        }

        public static void Patients()
        {
            Patient patient1 = new Patient();
            patient1.Title = "Patient 1";
            patient1.TimeOfReg = 13.33;
            patient1.TimeOfRelease = 14.25;
            patient1.Disease = "COVID-19";
            //patient1.missbruk = 0;
            

            Patient patient2 = new Patient();
            patient2.Title = "Patient 2";
            patient2.TimeOfReg = 14.32;
            patient2.TimeOfRelease = 15.31;
            patient2.Disease = " ";
            patient2.missbruk = 5;

            Patient patient3 = new Patient();
            patient3.Title = "Patient 3";
            patient3.TimeOfReg = 15.35;
            patient3.TimeOfRelease = 18.31;
            patient3.Disease = "Leukimia";
            patient3.missbruk = 6;
            

            Patient patient4 = new Patient();
            patient4.Title = "Patient 4";
            patient4.TimeOfReg = 18.35;
            patient4.TimeOfRelease = 18.55;
            patient4.Disease = "Cold";
            patient4.missbruk = 0;
            

            List<Patient> patientList = new List<Patient>();
            patientList.Add(patient1);
            patientList.Add(patient2);
            patientList.Add(patient3);
            patientList.Add(patient4);


            foreach (Patient item in patientList)
            {
                Console.WriteLine($"Title: {item.Title}\nTime of registration: {item.TimeOfReg}\nTime of release: {item.TimeOfRelease}\nDisease: {item.Disease}");
                Patient.Prescriptions(item.missbruk);
                Console.WriteLine();
            }



        }

       
    }
}