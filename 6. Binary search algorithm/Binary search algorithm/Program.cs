using System;

namespace Binary_search_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GenerateArray();
            a = BubbleSort(a);
            Console.Write("Enter search value: ");
            int value = CheckInputInt();
            Console.WriteLine();
            foreach (int i in a)
            {
                Console.Write(i);

            }
            int value_index = BinarySearch(a, value, 0, a.Length - 1);
            Console.WriteLine("\nValue Index is: " + value_index);
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

        static int[] GenerateArray()
        {
            Random random = new Random();
            Console.WriteLine("Enter number of array: ");
            int n = CheckInputInt();

            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 10);
            }
            return a;
        }

        static int[] BubbleSort(int[] a)
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
            return a;
        }

        static int BinarySearch(int[] a, int value, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = Math.Abs((left + right) / 2);
            if (a[middle] == value)
            {
                return middle;
            }
            else if (a[middle] > value)
            {
                return BinarySearch(a, value, left, middle - 1);
            }
            else
            {
                return BinarySearch(a, value, middle + 1, right);
            }
        }
    }
}
