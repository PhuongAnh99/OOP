using System;
using System.Collections.Generic;

namespace _54._Contact_Management_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.AddContact(contacts);
                        break;
                    case 2:
                        Manager.DisplayAll(contacts);
                        break;
                    case 3:
                        Manager.DeleteContact(contacts);
                        break;
                    case 4:
                        return;
                }
            }            
        }
    }
}
