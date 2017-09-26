using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDMG = int.Parse(Console.ReadLine());
            int goshoDMG = int.Parse(Console.ReadLine());
            int peshoHP = 100;
            int goshoHP = 100;

            for (int round = 1; ; round++)
            {
                if (round % 2 == 0) //Gosho attacks in even rounds
                {
                    peshoHP -= goshoDMG;
                    if (peshoHP > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP} health.");
                    }
                }
                else //Pesho attacks in odd rounds
                {
                    goshoHP -= peshoDMG;
                    if (goshoHP > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");
                    }
                }
                if (peshoHP <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }
                else if (goshoHP <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }
                if (round % 3 == 0) //healing
                {
                    peshoHP += 10;
                    goshoHP += 10;
                }
            }
        }
    }
}
