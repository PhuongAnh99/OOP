using System;

namespace _10._Linear_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GenerateArray();
            Console.Write("Enter search value: ");
            int value = CheckInputInt();
            Console.WriteLine();
            foreach (int i in a)
            {
                Console.Write(i);

            }
            int value_index = LinearSearch(a, value);
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
        static int LinearSearch(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
