using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate_management
{
    public class Candidate
    {
        private string Id;
        private string FirstName;
        private string LastName;
        private int BirthDate;
        private string Address;
        private string Phone;
        private string Email;
        private int CandidateType;

        public Candidate(string Id, string FirstName, string LastName, int BirthDate, 
            string Address, string Phone, string Email, int CandidateType)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CandidateType = CandidateType;
        }
        
        public string getId()
        {
            return Id;
        }
        public void setId(string new_Id)
        {
            this.Id = new_Id;
        }
        
        public string getFirstName()
        {
            return FirstName;
        }
        public void setFirstName(string new_FirstName)
        {
            this.FirstName = new_FirstName;
        }
        
        public string getLastName()
        {
            return LastName;
        }
        public void setLastName(string new_LastName)
        {
            this.LastName = new_LastName;
        }
        
        public int getBirthDate()
        {
            return BirthDate;
        }
        public void setBirthDate(int new_BirthDate)
        {
            this.BirthDate = new_BirthDate;
        }
        
        public string getAddress()
        {
            return Address;
        }
        public void setAddress(string new_Address)
        {
            this.Address = new_Address;
        }
        
        public string getPhone()
        {
            return Phone;
        }
        public void setPhone(string new_Phone)
        {
            this.Phone = new_Phone;
        }
        
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string new_Email)
        {
            this.Email = new_Email;
        }
        
        public int getCandidateType()
        {
            return CandidateType;
        }
        public void setCandidateType(int new_CandidateType)
        {
            this.CandidateType = new_CandidateType;
        }

        public string DisplayCandidate()
        {
            return this.FirstName + " " + this.LastName + " | " + this.BirthDate + " | "
                + this.Address + " | " + this.Id + " | " + this.Email + " | " + this.CandidateType;
        }

    }
}
