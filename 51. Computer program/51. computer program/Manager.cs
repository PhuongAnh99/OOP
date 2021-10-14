using System;
using System.Collections.Generic;
using System.Text;

namespace _51._computer_program
{
    class Manager
    {
        public static int Menu()
        {
            Console.WriteLine("========= Calculator Program =========");
            Console.WriteLine("1. Normal Calculator");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Please choice one option:");
            int choice = CheckInputIntLimit(1,3);
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
        public static string CheckInputOperator()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result == "+" || result == "-" || result == "*" || result == "/" || result == "^" || result == "=")
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Please input(+, -, *, /, ^)");
                    Console.WriteLine("Enter again: ");
                }
            }
        }
        public static void NormalCalculator()
        {
            Console.WriteLine("----- Normal Calculator -----");
            double memory;
            Console.WriteLine("Enter number: ");
            memory = CheckInputDouble();
            while (true)
            {
                Console.WriteLine("Enter Operator: ");
                string op = CheckInputOperator();
                if (op == "+")
                {
                    Console.WriteLine("Enter number: ");
                    double num = CheckInputDouble();
                    memory += num;
                    Console.WriteLine("Memory: " + memory);
                }
                if (op == "-")
                {
                    Console.WriteLine("Enter number: ");
                    double num = CheckInputDouble();
                    memory -= num;
                    Console.WriteLine("Memory: " + memory);
                }
                if (op == "*")
                {
                    Console.WriteLine("Enter number: ");
                    double num = CheckInputDouble();
                    memory *= num;
                    Console.WriteLine("Memory: " + memory);
                }
                if (op == "/")
                {
                    Console.WriteLine("Enter number: ");
                    double num = CheckInputDouble();
                    memory /= num;
                    Console.WriteLine("Memory: " + memory);
                }
                if (op == "^")
                {
                    Console.WriteLine("Enter number: ");
                    double num = CheckInputDouble();
                    memory = Math.Pow(memory, num);
                    Console.WriteLine("Memory: " + memory);
                }
                if (op == "=")
                {
                    Console.WriteLine("Memory: " + memory);
                    return;
                }
            }
        }

        public static void BMICalculator()
        {
            Console.WriteLine("----- BMI Calculator -----");
            Console.WriteLine("Enter Weight(kg): ");
            double weight = CheckInputDouble();
            Console.WriteLine("Enter Height(cm): ");
            double height = CheckInputDouble();

            double BMI = weight / (height / 100) / (height / 100);
            Console.WriteLine("BMI Number: " + BMI);
            if (BMI <= 19)
            {
                Console.WriteLine("BMI Status: Under-standard");
            }
            if (BMI > 19 && BMI <= 25)
            {
                Console.WriteLine("BMI Status: Standard");
            }
            if (BMI > 25 && BMI <= 30)
            {
                Console.WriteLine("BMI Status: Overweight");
            }
            if (BMI > 30 && BMI <= 40)
            {
                Console.WriteLine("BMI Status: Fat - should lose weight");
            }
            if (BMI > 40)
            {
                Console.WriteLine("BMI Status: Very fat - should lose weight immediately");
            }
        }
    }
}
