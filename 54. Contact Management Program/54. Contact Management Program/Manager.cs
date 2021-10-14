using System;
using System.Collections.Generic;
using System.Text;

namespace _54._Contact_Management_Program
{
    class Manager
    {
        /// <summary>
        /// Display Main Menu and return user option
        /// </summary>
        /// <returns></returns>
        public static int Menu()
        {
            Console.WriteLine("========= Contact program =========");
            Console.WriteLine("1. Add a Contact");
            Console.WriteLine("2. Display all Contact");
            Console.WriteLine("3. Delete a Contact");
            Console.WriteLine("4. Exit");
            int choice = Validation.CheckInputIntLimit(1, 4);
            return choice;
        }
        /// <summary>
        /// Allow user add new contact
        /// </summary>
        /// <param name="contacts"></param>
        public static void AddContact(List<Contact> contacts)
        {
            Console.WriteLine("-------- Add a Contact --------");
            Console.WriteLine("Enter Name: ");
            string FullName = Validation.CheckInputString();
            Console.WriteLine("Enter Group: ");
            string Group = Validation.CheckInputString();
            Console.WriteLine("Enter Address: ");
            string Address = Validation.CheckInputString();
            Console.WriteLine("Enter Phone: ");
            string Phone = Validation.CheckInputPhone();

            string[] name = FullName.Split(" ");
            string FirstName = name[0];
            string LastName = name[1];
            int Id = contacts.Count + 1;

            contacts.Add(new Contact(Id, FullName, FirstName, LastName, Group, Address, Phone));
            Console.WriteLine("Creat Success.");
        }
        /// <summary>
        /// Display all contacts
        /// </summary>
        /// <param name="contacts"></param>
        public static void DisplayAll(List<Contact> contacts)
        {
            Console.WriteLine("--------------------------------- Display all Contact ----------------------------");
            Console.WriteLine(String.Format("{0, -10}{1, -15}{2, -15}{3, -15}{4, -10}{5, -15}{6, -15}",
                "ID", "Name", "FirstName", "LastName", "Group", "Address", "Phone"));
            foreach (Contact c in contacts)
            {
                c.Display();
            }
        }
        /// <summary>
        /// Get contact by Id
        /// </summary>
        /// <param name="contacts"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Contact GetContactById(List<Contact> contacts, int id)
        {
            foreach (Contact c in contacts)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }
        /// <summary>
        /// Allow user delete a contact by Id
        /// </summary>
        /// <param name="contacts"></param>
        public static void DeleteContact(List<Contact> contacts)
        {
            Console.WriteLine("------- Delete a Contact -------");
            Console.WriteLine("Enter ID: ");
            int ID = Validation.CheckInputIntLimit(1, contacts.Count);
            contacts.Remove(GetContactById(contacts, ID));
            Console.WriteLine("Delete Success.");

            for (int i = ID - 1; i < contacts.Count; i++)
            {
                contacts[i].Id -= 1;
            }
        }
    }
}
