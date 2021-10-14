using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate_management
{
    public class Experience : Candidate
    {
        private int YearExperience;
        private string ProfessionalSkill;

        public Experience(int YearExperience, string ProfessionalSkill, 
            string Id, string FirstName, string LastName, int BirthDate,
            string Address, string Phone, string Email, int CandidateType)
            :base(Id, FirstName, LastName, BirthDate, Address, Phone, Email, CandidateType)
        {
            this.YearExperience = YearExperience;
            this.ProfessionalSkill = ProfessionalSkill;
        }

        public int getYearExperience()
        {
            return YearExperience;
        }

        public void setYearExperience(int new_YearExperience)
        {
            this.YearExperience = new_YearExperience;
        }

        public String getProfessionalSkill()
        {
            return ProfessionalSkill;
        }

        public void setProfessionalSkill(string ProfessionalSkill)
        {
            this.ProfessionalSkill = ProfessionalSkill;
        }

    }
}
