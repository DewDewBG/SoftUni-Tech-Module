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
            string profession = Console.ReadLine().ToLower();
            string drink = "Tea";

            switch (profession)
            {
                case "athlete":
                    drink = "Water"; break;
                case "softuni student":
                    drink = "Beer"; break;
                case "businessman":
                    drink = "Coffee"; break;
                case "businesswoman":
                    drink = "Coffee"; break;
                default:
                    drink = "Tea"; break;
            }

            Console.WriteLine(drink);

        }
    }
}
