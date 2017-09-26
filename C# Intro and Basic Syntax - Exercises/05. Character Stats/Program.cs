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
            string name = Console.ReadLine();
            int currentHp = int.Parse(Console.ReadLine());
            int maxHp = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int usedHp = maxHp - currentHp;
            int usedEnergy = maxEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            //hp
            Console.Write("Health: ");
            Console.Write('|');
            Console.Write(new string('|', currentHp));
            Console.Write(new string('.', usedHp));
            Console.WriteLine('|');

            //energy
            Console.Write("Energy: ");
            Console.Write('|');
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', usedEnergy));
            Console.WriteLine('|');
        }
    }
}
