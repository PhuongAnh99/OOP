using System;
using System.Collections.Generic;
using System.Text;

namespace _21._Manage_students_
{
    class Student : IComparable<Student>
    {
        private string id;
        private string studentName;
        private string semester;
        private string courseName;

        public Student(string id, string studentName, string semester, string courseName)
        {
            this.id = id;
            this.studentName = studentName;
            this.semester = semester;
            this.courseName = courseName;
        }
        public string Id
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
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        public string Semester
        {
            get
            {
                return semester;
            }
            set
            {
                semester = value;
            }
        }
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public int CompareTo(Student s)
        {
            return this.studentName.CompareTo(s.studentName);
        }
        public void Display()
        {
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}", this.studentName, this.semester, this.courseName));
        }
    }
}
