namespace LektionAnas20231031
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Övning Queue<>
            Console.WriteLine("Employee List: ");
            Doctors();
            Nurses();
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
            patient1.Title = "Patient";
            patient1.TimeOfReg = 13.30;
            patient1.TimeOfRelease = 17.30;
            patient1.Disease = "COVID-19";
            int DiseasePat1 = Patient.Prescriptions(2);

        }
    }
}