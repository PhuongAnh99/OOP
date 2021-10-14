using System;
using System.Collections.Generic;

namespace _55._Doctor_management_program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Doctor> doctors = new List<Doctor>();
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.AddDoctor(doctors);
                        break;
                    case 2:
                        Manager.UpdateDoctor(doctors);
                        break;
                    case 3:
                        Manager.DeleteDoctor(doctors);
                        break;
                    case 4:
                        Manager.SearchDoctor(doctors);
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
