using System;
using System.Collections.Generic;
using System.Text;

namespace _21._Manage_students_
{
    class Manager
    {
        public static int Menu()
        {
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Find and Sort");
            Console.WriteLine("3.Update/Delete");
            Console.WriteLine("4.Report");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Validation.CheckInputIntLimit(1, 5);
            return choice;
        }
        public static void CreateStudent(int count, List<Student> students)
        {
            while (true)
            {
                Console.WriteLine("Enter id: ");
                string Id = Validation.CheckInputString();
                Console.WriteLine("Enter name student: ");
                string Name = Validation.CheckInputString();
                Console.WriteLine("Enter semester: ");
                if (Validation.CheckIDExist(students, Id, Name))
                {
                    Console.WriteLine("Id has exist student. Pleas re-input.");
                    continue;
                }
                string Semester = Validation.CheckInputString();
                Console.WriteLine("Enter name course: ");
                string Course = Validation.CheckInputString();
                if (!Validation.CheckStudentExist(students, Id, Name, Semester, Course))
                {
                    students.Add(new Student(Id, Name, Semester, Course));
                    count++;
                    Console.WriteLine("Add student success.");
                    Console.WriteLine("----------------------------");
                }
                else
                {
                    Console.WriteLine("Duplicated.");
                    Console.WriteLine("----------------------------");
                }
                
                if (count > 10)
                {
                    Console.WriteLine("Do you want to continue (Y/N): ");
                    bool b1 = Validation.CheckInputYN();
                    if (!b1)
                    {
                        return;
                    }
                }
            }
        }
        public static void FindAndSort(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            List<Student> listStudentFindByName = ListStudentFindByName(students);
            if (listStudentFindByName.Count == 0)
            {
                Console.WriteLine("Not exist.");
            }
            else
            {
                listStudentFindByName.Sort();
                Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}", 
                    "Student name", "semester", "Course Name"));
                foreach (Student s in listStudentFindByName)
                {
                    s.Display();
                }
            }
        }
        public static List<Student> ListStudentFindByName(List<Student> students)
        {
            List<Student> newList = new List<Student>();
            Console.WriteLine("Enter name to search: ");
            string Name = Validation.CheckInputString();
            foreach (Student s in students)
            {
                if (s.StudentName.Contains(Name))
                {
                    newList.Add(s);
                }
            }
            return newList;
        }
        public static void UpdateOrDelete(int count, List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Console.WriteLine("Enter id: ");
            string Id = Validation.CheckInputString();
            List<Student> ListStudentFindById = GetListStudentById(students, Id);
            if (ListStudentFindById.Count == 0)
            {
                Console.WriteLine("Not found student.");
                return;
            }
            else
            {
                Student stud = GetStudentByListId(ListStudentFindById);
                Console.WriteLine("Do you want to update (U) or delete (D) student: ");
                if (Validation.CheckInputUD())
                {
                    Console.WriteLine("Enter semester: ");
                    string Semester = Validation.CheckInputString();
                    Console.WriteLine("Enter name course: ");
                    string Course = Validation.CheckInputString();

                    stud.Semester = Semester;
                    stud.CourseName = Course;
                    Console.WriteLine("Update success.");
                    return;
                }
                else
                {
                    students.Remove(stud);
                    count--;
                    Console.WriteLine("Delete success.");
                    return;
                }
            }
        }
        public static List<Student> GetListStudentById(List<Student> students, string Id)
        {
            List<Student> newListId = new List<Student>();
            foreach (Student s in students)
            {
                if (Id.ToLower() == s.Id.ToLower())
                {
                    newListId.Add(s);
                }
            }
            return newListId;
        }
        public static Student GetStudentByListId(List<Student> listStudentFindById)
        {
            Console.WriteLine("List student found: ");
            int count = 1;
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}",
                "Number", "Student name", "semester", "Course Name"));
            foreach (Student s in listStudentFindById)
            {
                Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}",
                    count, s.StudentName, s.Semester, s.CourseName));
                count++;
            }
            Console.WriteLine("Enter Number: ");
            int choice = Validation.CheckInputIntLimit(1, listStudentFindById.Count);
            return listStudentFindById[choice - 1];
        }
        public static void Report(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("List empty.");
                return;
            }
            List<Report> reports = new List<Report>();
            for (int i = 0; i < students.Count; i++)
            {
                int Total = 0;
                foreach (Student s in students)
                {
                    string Id = s.Id;
                    string Name = s.StudentName;
                    string Course = s.CourseName;
                    foreach (Student scount in students)
                    {
                        if (Id.ToLower() == scount.Id.ToLower()
                            && Course.ToLower() == scount.CourseName.ToLower())
                        {
                            Total++;
                        }
                    }
                    if (!Validation.CheckReportExist(reports, Name, Course, Total))
                    {
                        reports.Add(new Report(s.StudentName, s.CourseName, Total));
                    }
                }
            }
            foreach (Report r in reports)
            {
                Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}", r.StudentName, r.CourseName, r.TotalCourse));
            }
        }
    }
}
