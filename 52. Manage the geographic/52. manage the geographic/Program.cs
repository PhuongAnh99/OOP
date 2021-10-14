using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _52._manage_the_geographic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            while (true)
            {
                int choice = ManageEastAsiaCountries.Menu();
                switch (choice)
                {
                    case 1:
                        ManageEastAsiaCountries.InputCountry(countries);
                        break;
                    case 2:
                        ManageEastAsiaCountries.DisplayJustInput(countries);
                        break;
                    case 3:
                        ManageEastAsiaCountries.SearchCountry(countries);
                        break;
                    case 4:
                        ManageEastAsiaCountries.DisplayAllSorted(countries);
                        break;
                    case 5:
                        return;

                }
            }
        }
    }
}
