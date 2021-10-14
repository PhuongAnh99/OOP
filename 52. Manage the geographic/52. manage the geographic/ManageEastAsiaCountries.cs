using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _52._manage_the_geographic
{
    class ManageEastAsiaCountries
    {
        public static int Menu()
        {
            Console.WriteLine("1. Input the information of 11 countries in East Asia");
            Console.WriteLine("2. Display the information of country you've just input");
            Console.WriteLine("3. Search the information of country by user-entered name");
            Console.WriteLine("4. Display the information of countries sorted name in ascending");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = CheckInputIntLimit(1, 5);
            return choice;
        }

        public static int CheckInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < min || choice > max)
                    {
                        throw new Exception();
                    }
                    return choice;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please input number in range: {min} - {max}");
                    Console.WriteLine("Enter again: ");
                }

            }
        }
        public static double CheckInputDouble()
        {
            while (true)
            {
                try
                {
                    double result = Convert.ToDouble(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input double");
                    Console.WriteLine("Enter again: ");
                }
            }
        }
        public static string CheckInputString()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result == "")
                {
                    Console.WriteLine("Not Empty: ");
                    Console.WriteLine("Enter again:");
                }
                else
                {
                    return result;
                }
            }
        }
        public static void InputCountry(List<Country> countries)
        {
            Console.WriteLine("Enter code of contry: ");
            string CountryCode = CheckInputString();
            Console.WriteLine("Enter name of contry: ");
            string CountryName = CheckInputString();
            Console.WriteLine("Enter total area: ");
            double CountryArea = CheckInputDouble();
            Console.WriteLine("Enter terrain of contry: ");
            string CountryTerrain = CheckInputString();
            countries.Add(new Country(CountryTerrain, CountryCode, CountryName, CountryArea));
            Console.WriteLine("Add successful.");
        }
        public static void DisplayJustInput(List<Country> countries)
        {
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}", "ID", "Name", "Total Area",
                "Terrain"));
            countries[countries.Count - 1].display();
        }
        public static void SearchCountry(List<Country> countries)
        {
            Console.WriteLine("Enter the name you want to search for: ");
            string Cname = CheckInputString();
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}", "ID", "Name", "Total Area",
                "Terrain"));
            foreach (Country c in countries)
            {
                if (c.CountryName == Cname)
                {
                    c.display();
                }
            }
        }
        public static void DisplayAllSorted(List<Country> countries)
        {
            List<Country> CountrySort = countries.OrderBy(c => c.CountryName).ToList();
            Console.WriteLine(String.Format("{0,-20}{1,-20}{2,-20}{3,-20}", "ID", "Name", "Total Area",
                "Terrain"));
            foreach (Country i in CountrySort)
            {
                i.display();
            }
        }
    }
}
