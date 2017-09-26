using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalIngredients = int.Parse(Console.ReadLine());
            int totalKcal = 0;

            for (int i = 0; i < totalIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalKcal += 500; break;
                    case "tomato sauce":
                        totalKcal += 150; break;
                    case "salami":
                        totalKcal += 600; break;
                    case "pepper":
                        totalKcal += 50; break;

                }
            }
            Console.WriteLine($"Total calories: {totalKcal}");
        }
    }
}
