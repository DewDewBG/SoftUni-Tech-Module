using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double productVolume = double.Parse(Console.ReadLine());
            double productKcalPer100ml = double.Parse(Console.ReadLine());
            double productSugarPer100ml = double.Parse(Console.ReadLine());

            double totalKcal = (productVolume / 100) * productKcalPer100ml;
            double totalSugar = (productVolume / 100) * productSugarPer100ml;

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{totalKcal}kcal, {totalSugar}g sugars");

        }
    }
}
