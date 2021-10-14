using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _54._Contact_Management_Program
{
    class Validation
    {
        /// <summary>
        /// Check user input a integer
        /// </summary>
        /// <returns></returns>
        public static int CheckInputInt()
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input number.");
                    Console.Write("Enter again: ");
                }
            }
        }
        /// <summary>
        /// Check user input an integer from a certain range
        /// </summary>
        /// <returns></returns>
        public static int CheckInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < min || result > max)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Input must be an integer in range: {min} - {max}");
                    Console.Write("Enter again: ");
                }
            }
        }
        /// <summary>
        /// Check user input string
        /// </summary>
        /// <returns></returns>
        public static string CheckInputString()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result == "")
                {
                    Console.WriteLine("Not Empty.");
                    Console.Write("Enter again: ");
                }
                else
                {
                    return result;
                }
            }
        }
        /// <summary>
        /// Check user input phone number
        /// </summary>
        /// <returns></returns>
        public static string CheckInputPhone()
        {
            while (true)
            {
                string result = Console.ReadLine();
                string pattern = "^[(]?[0-9]{3}[)]?[-. ]?[0-9]{3}[-. ]?[0-9]{4}" + "|^[0-9]{3}[-][0-9]{3}[-][0-9]{4}[ ][a-z0-9]+";
                bool match = Regex.IsMatch(result, pattern);
                //bool match = Regex.IsMatch(result, "^[(]?[0-9]{3}[)]?[-. ]?[0-9]{3}[-. ]?[0-9]{4}" + "|^[0-9]{3}[-][0-9]{3}[-][0-9]{4}[ ][a-z0-9]+");
                if (match)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Please input Phone flow");
                    Console.WriteLine("• 1234567890");
                    Console.WriteLine("• 123-456-7890");
                    Console.WriteLine("• 123-456-7890 x1234");
                    Console.WriteLine("• 123-456-7890 ext1234");
                    Console.WriteLine("• (123)-456-7890");
                    Console.WriteLine("• 123.456.7890");
                    Console.WriteLine("• 123 456 7890");
                    Console.Write("Enter again: ");
                }
            }
        }
    }
}
