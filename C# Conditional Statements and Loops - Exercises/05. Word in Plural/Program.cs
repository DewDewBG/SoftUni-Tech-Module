using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            bool endsWithY = noun.EndsWith("y");
            bool endsWithOthers = noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z");

            if (endsWithY)
            {
                noun = noun.Remove(noun.Length - 1);
                noun += "ies";
            }
            else if (endsWithOthers)
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
        }
    }
}
