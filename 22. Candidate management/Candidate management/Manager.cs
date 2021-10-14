using System;
using System.Collections.Generic;
using System.Text;

namespace Candidate_management
{
    public class Manager
    {
        //Display Menu
        public static int Menu()
        {
            Console.WriteLine("CANDIDATE MANAGEMENT SYSTEM");
            Console.WriteLine("1. Experience");
            Console.WriteLine("2. Fresher");
            Console.WriteLine("3. Internship");
            Console.WriteLine("4. Searching");
            Console.WriteLine("5. Exit");
            Console.WriteLine("(Please choose 1 to Create Experience Candidate, 2 to Create Fresher Candidate, 3 to Internship Candidate, 4 to Searching and 5 to Exit program).");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        //allow user input common information of candidate
        public static void CreatCandidate(Candidate[] Candidates, int Type)
        {
            //loop until user don't want to create new candidate
            while (true)
            {
                Console.WriteLine("Enter Id: ");
                string Id = Console.ReadLine();
                Console.WriteLine("Enter First Name: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name: ");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter Birth Date: ");
                int BirthDate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter Phone: ");
                string Phone = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                string Email = Validation.CheckEmailInput();

                Candidate candidate = new Candidate(Id, FirstName, LastName, BirthDate, Address, Phone, Email, Type);

                switch (Type)
                {
                    case 0:
                        CreatExperience(Candidates, candidate);
                        break;
                    case 1:
                        CreatFresher(Candidates, candidate);
                        break;
                    case 2:
                        CreatIntern(Candidates, candidate);
                        break;
                    default:
                        break;
                }

                //check user want to create new candidate or not
                Console.WriteLine("Do you want to continue (Y/N): ");
                string answer = Console.ReadLine();
                if (answer != "Y")
                {
                    return;
                }
            }    
        }

        //allow user create experience candidate
        public static void CreatExperience(Candidate[] Candidates, Candidate candidate)
        {
            Console.WriteLine("Enter year of experience: ");
            int YearExperience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter professional skill: ");
            string ProfessionalSkill = Console.ReadLine();

            int index = Array.IndexOf(Candidates, null);
            Candidates[index] = new Experience(YearExperience, ProfessionalSkill,
                candidate.getId(), candidate.getFirstName(), candidate.getLastName(),
                candidate.getBirthDate(), candidate.getAddress(),
                candidate.getPhone(), candidate.getEmail(), candidate.getCandidateType());

            Console.WriteLine("Create success.");
        }

        //allow user create fresher candidate
        public static void CreatFresher(Candidate[] Candidates, Candidate candidate)
        {
            Console.WriteLine("Enter graduation date: ");
            string GraduationDate = Console.ReadLine();

            Console.WriteLine("Enter graduation rank: ");
            string GraduationRank = Console.ReadLine();

            int index = Array.IndexOf(Candidates, null);
            Candidates[index] = new Fresher(GraduationDate, GraduationRank,
                candidate.getId(), candidate.getFirstName(), candidate.getLastName(),
                candidate.getBirthDate(), candidate.getAddress(),
                candidate.getPhone(), candidate.getEmail(), candidate.getCandidateType());

            Console.WriteLine("Create success.");
        }

        //allow user create internship
        public static void CreatIntern(Candidate[] Candidates, Candidate candidate)
        {
            Console.WriteLine("Enter major: ");
            string Major = Console.ReadLine();

            Console.WriteLine("Enter semester: ");
            string Semester = Console.ReadLine();

            Console.WriteLine("Enter university: ");
            string University = Console.ReadLine();

            int index = Array.IndexOf(Candidates, null);
            Candidates[index] = new Intern(Major, Semester, University,
                candidate.getId(), candidate.getFirstName(), candidate.getLastName(),
                candidate.getBirthDate(), candidate.getAddress(),
                candidate.getPhone(), candidate.getEmail(), candidate.getCandidateType());

            Console.WriteLine("Create success.");
        }

        //allow user search candidate by name
        public static void SearchCandidate(Candidate[] Candidates)
        {
            DisplayAllCandidates(Candidates);
            Console.WriteLine("Input Candidate name (First name or Last name): ");
            string NameSreach = Console.ReadLine();
            Console.WriteLine("Input type of candidate: ");
            int TypeSearch = Convert.ToInt32(Console.ReadLine());

            foreach (Candidate candidate in Candidates)
            {
                if (candidate != null)
                {
                    if (candidate.getCandidateType() == (TypeSearch - 1)
                    && (candidate.getFirstName().Contains(NameSreach)
                    || candidate.getLastName().Contains(NameSreach)))
                    {
                        Console.WriteLine(candidate.DisplayCandidate());
                    }
                }
            }

        }

        //Display list of all candidate name
        public static void DisplayAllCandidates(Candidate[] Candidates)
        {
            Console.WriteLine("===========EXPERIENCE CANDIDATE============");
            foreach (Candidate candidate in Candidates)
            {
                if (candidate != null)
                {
                    if (candidate.getCandidateType() == 0)
                    {
                        Console.WriteLine(candidate.getFirstName() + " " + candidate.getLastName());
                    }
                }
            }

            Console.WriteLine("===========FRESHER CANDIDATE============");
            foreach (Candidate candidate in Candidates)
            {
                if (candidate != null)
                {
                    if (candidate.getCandidateType() == 1)
                    {
                        Console.WriteLine(candidate.getFirstName() + " " + candidate.getLastName());
                    }
                }
            }

            Console.WriteLine("===========INTERN CANDIDATE============");
            foreach (Candidate candidate in Candidates)
            {
                if (candidate != null)
                {
                    if (candidate.getCandidateType() == 2)
                    {
                        Console.WriteLine(candidate.getFirstName() + " " + candidate.getLastName());
                    }
                }
            }
        }
    }
}
