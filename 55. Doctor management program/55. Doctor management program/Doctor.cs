using System;
using System.Collections.Generic;
using System.Text;

namespace _55._Doctor_management_program
{
    class Doctor
    {
        private string code;
        private string name;
        private string specialization;
        private int availability;

        public Doctor(string code, string name, string specialization, int availability)
        {
            this.code = code;
            this.name = name;
            this.specialization = specialization;
            this.availability = availability;
        }
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Specialization
        {
            get
            {
                return specialization;
            }
            set
            {
                specialization = value;
            }
        }
        public int Availability
        {
            get
            {
                return availability;
            }
            set
            {
                availability = value;
            }
        }
        public void Display()
        {
            Console.WriteLine(String.Format("{0, -10}{1, -15}{2, -25}{3, 6}", 
                code, name, specialization, availability));
        }
    }
}
