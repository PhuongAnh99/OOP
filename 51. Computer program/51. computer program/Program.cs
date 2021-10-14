using System;

namespace _51._computer_program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = Manager.Menu();
                switch (choice)
                {
                    case 1:
                        Manager.NormalCalculator();
                        break;
                    case 2:
                        Manager.BMICalculator();
                        break;
                    case 3:
                        return;
                }

            }
        }
    }
}
