using System;

namespace Bubble_sort_algorithm
{
    class Program
    {
        static void Main()
        {
            Program x = new Program();
            var n = x.InputSizeOfArray();
            var a = x.InputValueOfArray(n);
            x.BubbleSort(a);
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

        public int InputSizeOfArray()
        {
            Console.Write("Enter number of array: ");
            int n = CheckInputInt();
            return n;
        }

        public int[] InputValueOfArray(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter a[{i}]: ");
                a[i] = CheckInputInt();
            }
            return a;
        }

        public void BubbleSort(int[] a)
        { 
            Console.Write("Unsorted array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length -i -1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
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


