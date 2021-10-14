using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate_management
{
    public class Fresher : Candidate
    {
        private string GraduationDate;
        private string GraduationRank;

        public Fresher(string GraduationDate, string GraduationRank,
            string Id, string FirstName, string LastName, int BirthDate,
            string Address, string Phone, string Email, int CandidateType)
            : base(Id, FirstName, LastName, BirthDate, Address, Phone, Email, CandidateType)
        {
            this.GraduationDate = GraduationDate;
            this.GraduationRank = GraduationRank;
        }

        public string getGraduationDate()
        {
            return GraduationDate;
        }

        public void setGraduationDate(string new_GraduationDate)
        {
            this.GraduationDate = new_GraduationDate;
        }

        public string getGraduationRank()
        {
            return GraduationRank;
        }

        public void setGraduationRank(string GraduationRank)
        {
            this.GraduationRank = GraduationRank;
        }
    }
}
