using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNumber = Convert.ToInt32(Console.ReadLine(), 16);

            Console.WriteLine(hexNumber);
        }
    }
}
