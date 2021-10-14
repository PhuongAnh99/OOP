using System;
using System.Collections.Generic;
using System.Text;

namespace _21._Manage_students_
{
    class Validation
    {
        public static int CheckInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < min || choice > max)
                    {
                        throw new Exception();
                    }
                    return choice;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please input number in range: {min} - {max}");
                    Console.WriteLine("Enter again: ");
                }

            }
        }
        public static string CheckInputString()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result == "")
                {
                    Console.WriteLine("Not Empty: ");
                    Console.WriteLine("Enter again:");
                }
                else
                {
                    return result;
                }
            }
        }
        public static bool CheckInputYN()
        {
            while (true)
            {
                string result = CheckInputString();
                if (result.ToUpper() == "Y")
                {
                    return true;
                }
                if (result.ToUpper() == "N")
                {
                    return false;
                }
                Console.WriteLine("Please input y/Y or n/N.");
                Console.WriteLine("Enter Again: ");
            }
        }
        public static bool CheckInputUD()
        {
            while (true)
            {
                string result = CheckInputString();
                if (result.ToUpper() == "U")
                {
                    return true;
                }
                if (result.ToUpper() == "D")
                {
                    return false;
                }
                Console.WriteLine("Please input u/U or d/D.");
                Console.WriteLine("Enter Again: ");
            }
        }
        public static string CheckInputCourse()
        {
            while (true)
            {
                string result = CheckInputString();
                if (result.ToLower() == "java" || result.ToLower() == ".net" || result.ToLower() == "c/c++")
                {
                    return result;
                }
                Console.WriteLine("There are only three courses: Java, .Net, C/C++");
                Console.WriteLine("Enter again: ");
            }
        }
        public static bool CheckStudentExist(List<Student> students, 
            string id, string studentName, string semester, string courseName)
        {
            foreach (Student s in students)
            {
                if (id.ToLower() == s.Id.ToLower()
                    && studentName.ToLower() == s.StudentName.ToLower()
                    && semester.ToLower() == s.Semester.ToLower()
                    && courseName.ToLower() == s.CourseName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckIDExist(List<Student> students,
            string id, string studentName)
        {
            foreach (Student s in students)
            {
                if (id.ToLower() == s.Id.ToLower()
                    && !(studentName.ToLower() == s.StudentName.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckReportExist(List<Report> reports, string Name, string Course, int Total)
        {
            foreach (Report r in reports)
            {
                if (Name.ToLower() == r.CourseName.ToLower()
                    && Course.ToLower() == r.CourseName.ToLower()
                    && Total == r.TotalCourse)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
