using System;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;

            Console.WriteLine($"{area:f2}");
        }
    }
}
