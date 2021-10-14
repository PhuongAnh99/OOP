using System;
using System.Collections.Generic;
using System.Text;

namespace _11._Change_base_number_system
{
    class Process
    {
        public string BinToDec(string a)
        {
            string dec = Convert.ToInt32(a, 2).ToString();
            return dec;
        }
        public string HexToDec(string a)
        {
            string dec = Convert.ToInt32(a, 16).ToString();
            return dec;
        }
        public string DecToBin(string a)
        {
            int dec = Convert.ToInt32(a);
            string bin = Convert.ToString(dec, 2);
            return bin;
        }
        public string DecToHex(string a)
        {
            int dec = Convert.ToInt32(a);
            string hex = Convert.ToString(dec, 16);
            return hex;
        }
        public string BinToHex(string a)
        {
            int dec = Convert.ToInt32(a, 2);
            string hex = Convert.ToString(dec, 16);
            return hex;
        }
        public string HexToBin(string a)
        {
            int dec = Convert.ToInt32(a, 16);
            string bin = Convert.ToString(dec, 2);
            return bin;
        }


    }
}
