using System;

namespace _11._Change_base_number_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Process conv = new Process();
            Console.WriteLine("1 is binary, 2 is decimal,  3 is hexadecimal");
            Console.WriteLine("Convert from: ");
            string from = Console.ReadLine();
            Console.WriteLine("Convert to: ");
            string to = Console.ReadLine();
            Console.WriteLine("Enter your input value: ");
            string value = Console.ReadLine();

            string a;

            if (from == "1" && to == "2")
            {
                a = conv.BinToDec(value);
                Console.WriteLine($"Your output value: {a}");
            }
            if (from == "1" && to == "3")
            {
                a = conv.BinToHex(value);
                Console.WriteLine($"Your output value: {a}");
            }
            if (from == "2" && to == "1")
            {
                a = conv.DecToBin(value);
                Console.WriteLine($"Your output value: {a}");
            }
            if (from == "2" && to == "3")
            {
                a = conv.DecToHex(value);
                Console.WriteLine($"Your output value: {a}");
            }
            if (from == "3" && to == "1")
            {
                a = conv.HexToBin(value);
                Console.WriteLine($"Your output value: {a}");
            }
            if (from == "3" && to == "2")
            {
                a = conv.HexToDec(value);
                Console.WriteLine($"Your output value: {a}");
            }
        }
    }
}
