using System;

namespace _4._Quick_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = InputSizeOfArray();
            int[] a = InputValueOfArray(n);
            DisplayArray(a);
            QuickSort(a, 0, a.Length -1);
            DisplayArray(a);
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
            Console.WriteLine("Enter number of Array: ");
            int n = CheckInputInt();
            return n;
        }

        static int[] InputValueOfArray(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter a[{i}]: ");
                a[i] = CheckInputInt();
            }
            return a;
        }

        static int Partition(int[] a, int i, int j)
        {
            int pivot = a[Math.Abs((i + j) / 2)];
            while (i <= j)
            {
                while (a[i] < pivot)
                {
                    i++;
                }
                while (a[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            return i;
        }

        static void QuickSort(int[] a, int left, int right)
        {
            int index = Partition(a, left, right);
            if (left < index - 1)
            {
                QuickSort(a, left, index - 1);
            }
            if (index < right)
            {
                QuickSort(a, index, right);
            }
        }

        static void DisplayArray(int[] a)
        {
            foreach (var i in a)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }


    }
}
