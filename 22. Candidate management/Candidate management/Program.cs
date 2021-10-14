using System;

namespace Candidate_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate[] Candidates = new Candidate[20];
            
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.CreatCandidate(Candidates, 0);
                        break;
                    case 2:
                        Manager.CreatCandidate(Candidates, 1);
                        break;
                    case 3:
                        Manager.CreatCandidate(Candidates, 2);
                        break;
                    case 4:
                        Manager.SearchCandidate(Candidates);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
