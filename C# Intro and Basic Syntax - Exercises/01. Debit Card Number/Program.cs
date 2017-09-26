using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstFour = int.Parse(Console.ReadLine());
            int secondFour = int.Parse(Console.ReadLine());
            int thirdFour = int.Parse(Console.ReadLine());
            int lastFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstFour:d4} {secondFour:d4} {thirdFour:d4} {lastFour:d4}");

        }
    }
}
