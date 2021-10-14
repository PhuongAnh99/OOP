using System;
using System.Collections.Generic;
using System.Text;

namespace _55._Doctor_management_program
{
    class Manager
    {
        /// <summary>
        /// Display Main Menu and return user option
        /// </summary>
        /// <returns></returns>
        public static int Menu()
        {
            Console.WriteLine("========= Doctor Management ==========");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Update Doctor");
            Console.WriteLine("3. Delete Doctor");
            Console.WriteLine("4. Search Doctor");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Validation.CheckInputIntLimit(1,5);
            return choice;
        }
        /// <summary>
        /// Allow user to add a new Doctor
        /// </summary>
        /// <param name="doctors"></param>
        public static void AddDoctor(List<Doctor> doctors)
        {
            Console.WriteLine("--------- Add Doctor ----------");
            Console.WriteLine("Enter Code: ");
            string Code = Validation.CheckInputCode(doctors);
            Console.WriteLine("Enter Name: ");
            string Name = Validation.CheckInputString();
            Console.WriteLine("Enter Specialization: ");
            string Specialization = Validation.CheckInputString();
            Console.WriteLine("Enter Availability: ");
            int Availability = Validation.CheckInputInt();

            doctors.Add(new Doctor(Code, Name, Specialization, Availability));
            Console.WriteLine("Create Success.");
        }
        /// <summary>
        /// Allow user to Update Doctor's Info
        /// </summary>
        /// <param name="doctors"></param>
        public static void UpdateDoctor(List<Doctor> doctors)
        {
            Console.WriteLine("--------- Update Doctor -------");
            Console.WriteLine("Enter Code: ");
            Doctor DoctorWantUpdate = Validation.CheckCodeExist(doctors);
            
            Console.WriteLine("Enter Name: ");
            string Name = Console.ReadLine();
            if (!String.IsNullOrEmpty(Name))
            {
                DoctorWantUpdate.Name = Name;
            }
            
            Console.WriteLine("Enter Specialization: ");
            string Specialization = Console.ReadLine();
            if (!String.IsNullOrEmpty(Specialization))
            {
                DoctorWantUpdate.Specialization = Specialization;
            }
            
            Console.WriteLine("Enter Availability: ");
            string sAvailability = Console.ReadLine();
            if (!String.IsNullOrEmpty(sAvailability))
            {
                int Availability = Validation.CheckConvertInt(sAvailability);
                DoctorWantUpdate.Availability = Availability;
            }
            Console.WriteLine("Update Success.");
        }
        /// <summary>
        /// Allow user to delete a Doctor
        /// </summary>
        /// <param name="doctors"></param>
        public static void DeleteDoctor(List<Doctor> doctors)
        {
            Console.WriteLine("--------- Delete Doctor -------");
            Console.WriteLine("Enter Code: ");
            doctors.Remove(Validation.CheckCodeExist(doctors));
            Console.WriteLine("Delete Success.");
        }
        /// <summary>
        /// Allow user to search doctor info by name
        /// </summary>
        /// <param name="doctors"></param>
        public static void SearchDoctor(List<Doctor> doctors)
        {
            Console.WriteLine("Enter Name: ");
            string Name = Validation.CheckInputString();
            List<Doctor> doctorsFind = new List<Doctor>();
            foreach (Doctor d in doctors)
            {
                if (d.Name.Contains(Name))
                {
                    doctorsFind.Add(d);
                }
            }
            Console.WriteLine("------------Search Results------------");
            Console.WriteLine(String.Format("{0, -10}{1, -15}{2, -25}{3, -20}",
                "Code", "Name", "Specialization", "Availability"));
            foreach (Doctor d in doctorsFind)
            {
                d.Display();
            }
        }
    }
}
