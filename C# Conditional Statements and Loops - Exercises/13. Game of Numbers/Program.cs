using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        return;
                    }
                    combinations++;
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
