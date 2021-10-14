using System;

namespace Selection_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = InputSizeOfArray();
            int[] a = InputValueOfArray(n);
            SelectionSort(a);
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

        static void SelectionSort(int[] a)
        {
            Console.Write("Unsorted array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }


            for (int i = 0; i < a.Length-1; i++)
            {
                int MinIndex = i;
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j] < a[MinIndex])
                    {
                        MinIndex = j;
                    }
                }

                if (MinIndex != i)
                {
                    int temp = a[MinIndex];
                    a[MinIndex] = a[i];
                    a[i] = temp;
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
