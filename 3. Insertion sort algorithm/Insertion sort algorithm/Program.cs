using System;

namespace Insertion_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = InputSizeOfArray();
            int[] a = InputValueOfArray(n);
            InsertionSort(a);
            DisplaySort(a);
        }

        static int CheckInputInt()
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
                    Console.WriteLine("Please input number. Enter again: ");
                }
            }
        }

        static int InputSizeOfArray()
        {
            Console.Write("Enter number of array: ");
            int n = CheckInputInt();
            return n;
        }

        static int[] InputValueOfArray(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter a[{i}]: ");
                a[i] = CheckInputInt();
            }
            return a;
        }

        static void InsertionSort(int[] a)
        {
            Console.Write("Unsorted array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (a[i - j] < a[i - j - 1])
                    {
                        int temp = a[i - j];
                        a[i - j] = a[i - j - 1];
                        a[i - j - 1] = temp;
                    }
                }
            }
        }

        static void DisplaySort(int[] a)
        {
            Console.WriteLine();
            Console.Write("Sorted array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
