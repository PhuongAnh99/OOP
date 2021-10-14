using System;
using System.Collections.Generic;
using System.Text;

namespace _54._Contact_Management_Program
{
    class Contact
    {
        private int id;
        private string fullName;
        private string firstName;
        private string lastName;
        private string group;
        private string address;
        private string phone;

        public Contact(int id, string fullName, string firstName, string lastName, string group, string address, string phone)
        {
            this.id = id;
            this.fullName = fullName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.group = group;
            this.address = address;
            this.phone = phone;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public void Display()
        {
            Console.WriteLine(String.Format("{0, -10}{1, -15}{2, -15}{3, -15}{4, -10}{5, -15}{6, -15}", 
                this.id, this.fullName, this.firstName, this.lastName, this.group, this.address, this.phone));
        }
    }
}
