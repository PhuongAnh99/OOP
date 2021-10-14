using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate_management
{
    class Intern : Candidate
    {
        private string Major;
        private string Semester;
        private string University;

        public Intern(string Major, string Semester, string University,
           string Id, string FirstName, string LastName, int BirthDate,
           string Address, string Phone, string Email, int CandidateType)
           : base(Id, FirstName, LastName, BirthDate, Address, Phone, Email, CandidateType)
        {
            this.Major = Major;
            this.Semester = Semester;
            this.University = University;
        }
        
        public string getMajor()
        {
            return Major;
        }

        public void setMajor(string new_Major)
        {
            this.Major = new_Major;
        }
        
        public string getSemester()
        {
            return Semester;
        }

        public void setSemester(string new_Semester)
        {
            this.Semester = new_Semester;
        }
        
        public string getUniversity()
        {
            return University;
        }

        public void setUniversity(string new_University)
        {
            this.University = new_University;
        }
    }
}
