using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double discount = 0;
            int priceOfPackage = 0;
            int priceOfHall = 7500; //Great Hall
            string hallName = "Great Hall";
            int totalprice = 0;
            double discountedPrice = 0;
            double pricePerPerson = 0;

            /* Small Hall   Terrace   Great Hall
                $2500        $5000      $7500   
                 50           100        120  */

            if (countOfPeople > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "normal":
                    discount = 0.95;
                    priceOfPackage = 500; break;
                case "gold":
                    discount = 0.90;
                    priceOfPackage = 750; break;
                case "platinum":
                    discount = 0.85;
                    priceOfPackage = 1000; break;
            }

            if (countOfPeople <= 50)
            {
                priceOfHall = 2500;
                hallName = "Small Hall";
            }
            else if (countOfPeople > 50 && countOfPeople <= 100)
            {
                priceOfHall = 5000;
                hallName = "Terrace";
            }

            totalprice = priceOfHall + priceOfPackage;
            discountedPrice = totalprice * discount;
            pricePerPerson = discountedPrice / countOfPeople;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

        }
    }
}
