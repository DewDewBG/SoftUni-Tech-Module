using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string tf = Console.ReadLine().ToLower();
            
            switch (tf)
            {
                case "true":
                    Console.WriteLine("Yes"); break;
                case "false":
                    Console.WriteLine("No"); break;

            }
        }
    }
}
