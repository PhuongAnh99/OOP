using System;

namespace _9._Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 46; i++)
            {
                Console.Write(Fibo(i) + ";");

            }
        }

        static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }
    }
}
