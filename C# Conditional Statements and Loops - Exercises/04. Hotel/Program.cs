using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int countOfNights = int.Parse(Console.ReadLine());
            double pricePerNightStudio = 68; //For July, August and December
            double pricePerNightDouble = 77; //For July, August and December
            double pricePerNightSuite = 89; //For July, August and December
            

            if (countOfNights > 14)
            {
                pricePerNightSuite *= 0.85; //15% discount 
            }

            if (month == "may" || month == "october")
            {
                pricePerNightStudio = 50;
                pricePerNightDouble = 65;
                pricePerNightSuite = 75;
                if (countOfNights > 7)
                {
                    pricePerNightStudio *= 0.95; //5% discount
                }
            }
            else if (month == "june" || month == "september")
            {
                pricePerNightStudio = 60;
                pricePerNightDouble = 72;
                pricePerNightSuite = 82;
                if (countOfNights > 14)
                {
                    pricePerNightDouble *= 0.90; //10% discount
                }
            }

            double totalPriceForStudio = pricePerNightStudio * countOfNights;
            double totalPriceForDouble = pricePerNightDouble * countOfNights;
            double totalPriceForSuite = pricePerNightSuite * countOfNights;

            if (month == "september" && countOfNights > 7 || month == "october" && countOfNights > 7)
            {
                totalPriceForStudio -= pricePerNightStudio;
            }

            Console.WriteLine($"Studio: {totalPriceForStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceForDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceForSuite:f2} lv.");
        }
    }
}
