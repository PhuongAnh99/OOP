using System;
using System.Collections.Generic;
using System.Text;

namespace _21._Manage_students_
{
    class Report
    {
        private string studentName;
        private string courseName;
        private int totalCourse;

        public Report(string studentName, string courseName, int totalCourse)
        {
            this.studentName = studentName;
            this.courseName = courseName;
            this.totalCourse = totalCourse;
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
        public int TotalCourse
        {
            get
            {
                return totalCourse;
            }
            set
            {
                totalCourse = value;
            }
        }
    }
}
