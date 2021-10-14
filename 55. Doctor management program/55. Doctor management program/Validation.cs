using System;
using System.Collections.Generic;
using System.Text;

namespace _55._Doctor_management_program
{
    class Validation
    {
        /// <summary>
        /// Check user input an integer.
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
                    Console.WriteLine("Input must be an integer.");
                    Console.WriteLine("Enter agian: ");
                }
            }
        }
        /// <summary>
        /// Check user input an integer in range(min,max)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
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
                    Console.WriteLine("Enter again: ");
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
                if (String.IsNullOrEmpty(result))
                {
                    Console.WriteLine("The input is not allowed to be empty.");
                    Console.WriteLine("Enter again: ");
                }
                else
                {
                    return result;
                }
            }
        }
        /// <summary>
        /// Check user input Code to add a new Doctor
        /// </summary>
        /// <param name="doctors"></param>
        /// <returns></returns>
        public static string CheckInputCode(List<Doctor> doctors)
        {
            while (true)
            {
                try
                {
                    string result = Console.ReadLine();
                    foreach (Doctor d in doctors)
                    {
                        if (d.Code == result)
                        {
                            throw new Exception();
                        }
                    }
                    if (String.IsNullOrEmpty(result))
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Code must not null or duplicate in the DB.");
                    Console.WriteLine("Enter again: ");
                }
            }
        }
        /// <summary>
        /// Check Code existed in DB or not
        /// </summary>
        /// <param name="doctors"></param>
        /// <returns></returns>
        public static Doctor CheckCodeExist(List<Doctor> doctors)
        {
            while (true)
            {
                string result = Console.ReadLine();
                foreach (Doctor d in doctors)
                {
                    if (d.Code == result)
                    {
                        return d;
                    }
                }
                Console.WriteLine("Code does not exist Doctor");
                Console.WriteLine("Enter again: ");
            }
        }
        /// <summary>
        /// Check a string can/cannot convert to an integer
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CheckConvertInt(string s)
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(s);
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("This object must be an integer.");
                }
            }
        }
    }
}
