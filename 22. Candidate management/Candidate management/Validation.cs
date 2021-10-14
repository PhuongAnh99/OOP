using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Candidate_management
{
    class Validation
    {
        public static string CheckEmailInput()
        {
            while (true)
            {
                string result = Console.ReadLine();
                bool match = Regex.IsMatch(result, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (match)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Email with format <account name>@<domain>");
                    Console.WriteLine("Enter Again: ");
                }

            }
        }
    }
}
