using System;
using System.Collections.Generic;

namespace _21._Manage_students_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int count = 0;
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.CreateStudent(count, students);
                        break;
                    case 2:
                        Manager.FindAndSort(students);
                        break;
                    case 3:
                        Manager.UpdateOrDelete(count, students);
                        break;
                    case 4:
                        Manager.Report(students);
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
