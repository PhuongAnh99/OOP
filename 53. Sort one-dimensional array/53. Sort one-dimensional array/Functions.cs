using System;
using System.Collections.Generic;
using System.Text;

namespace _53._Sort_one_dimensional_array
{
    class Functions
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
                    Console.WriteLine("Input must be a number.");
                    Console.WriteLine("Enter Again: ");
                }
            }
        }
        /// <summary>
        /// Check user input length of array
        /// </summary>
        /// <returns></returns>
        public static int CheckInputIntLength()
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < 1)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input number and number is greater than zero.");
                    Console.WriteLine("Enter Again: ");
                }
            }
        }
        /// <summary>
        /// Check user input choice in menu
        /// </summary>
        /// <returns></returns>
        public static int CheckInputIntLimit()
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < 1 || result > 4)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Input must be a number in range: 1 - 4.");
                }
            }
        }
        /// <summary>
        /// Display main menu
        /// </summary>
        /// <returns></returns>
        public static int Menu()
        {
            Console.WriteLine("========= Bubble Sort program =========");
            Console.WriteLine("1. Input Element");
            Console.WriteLine("2. Sort Ascending");
            Console.WriteLine("3. Sort Descending");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please choice one option:");

            int choice = CheckInputIntLimit();
            return choice;
        }
        /// <summary>
        /// allow user input length and elements of array
        /// </summary>
        /// <returns></returns>
        public static int[] InputElement()
        {
            Console.WriteLine("----- Input Element -----");
            Console.WriteLine("Input Length Of Array");
            Console.WriteLine("Enter Number: ");
            int aLength = CheckInputIntLength();
            int[] arr = new int[aLength];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}: ");
                arr[i] = CheckInputInt();
            }
            Console.WriteLine("Creat Success!");
            return arr;
        }
        /// <summary>
        /// Sort the array in ascending order
        /// </summary>
        /// <param name="a"></param>
        public static void SortAscending(int[] a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Array is empty.");
            }
            else
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - i - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < a.Length - 1; i++)
                {
                    Console.Write("[{0}]->", a[i]);
                }
                Console.WriteLine("[{0}]", a[a.Length - 1]);
            }
        }
        /// <summary>
        /// Sort the array in descending order
        /// </summary>
        /// <param name="a"></param>
        public static void SortDescending(int[] a)
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Array is empty.");
            }
            else
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = 0; j < a.Length - i - 1; j++)
                    {
                        if (a[j] < a[j + 1])
                        {
                            int temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < a.Length - 1; i++)
                {
                    Console.Write("[{0}]->", a[i]);
                }
                Console.WriteLine("[{0}]", a[a.Length - 1]);
            }
        }
    }
}
