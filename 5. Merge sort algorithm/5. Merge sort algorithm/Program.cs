using System;

namespace _5._Merge_sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = InputSizeOfArray();
            int[] a = InputValueOfArray(n);
            DisplayArray(a);
            MergeSort(a, 0, a.Length - 1);
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

        static void Merge (int[] a, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                L[i] = a[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = a[m + 1 + j];
            }

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] < R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                a[k] = R[j];
                j++;
                k++;
            }
        }
        static void MergeSort (int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = Math.Abs((l + r) / 2);
                MergeSort(a, l, m);
                MergeSort(a, m + 1, r);
                Merge(a, l, m, r);
            }
        }
        static void DisplayArray(int[] a)
        {
            foreach (var i in a)
            {
                Console.Write(i+";");
            }
            Console.WriteLine();
        }
    }
}
