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
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink = "Tea";
            double price = quantity * 1.2;

            /* Water  Coffee    Beer    Tea
        Price   0.70    1.00    1.70    1.20 */

            if (profession == "Athlete")
            {
                drink = "Water";
                price = quantity * 0.7;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = quantity * 1.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = quantity * 1.0;
            }

            Console.WriteLine($"The {profession} has to pay {price:f2}.");

        }
    }
}
