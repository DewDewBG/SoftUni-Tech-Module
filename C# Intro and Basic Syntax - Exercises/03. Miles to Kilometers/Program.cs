using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double mileToKm = miles * 1.60934;

            Console.WriteLine($"{mileToKm:f2}");
        }
    }
}
