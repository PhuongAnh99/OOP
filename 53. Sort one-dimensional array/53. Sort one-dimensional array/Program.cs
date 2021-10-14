using System;

namespace _53._Sort_one_dimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[0];
            while (true)
            {
                int choice = Functions.Menu();
                switch (choice)
                {
                    case 1:
                        a = Functions.InputElement();
                        break;
                    case 2:
                        Functions.SortAscending(a);
                        break;
                    case 3:
                        Functions.SortDescending(a);
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
