using System;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            uint years = centuries * 100;
            uint days = centuries * 36524;
            ulong hours = centuries * 876576;
            ulong minutes = centuries * 3155673600;
            ulong seconds = minutes * 60;
            ulong milseconds = seconds * 60;
            ulong microseconds = milseconds * 60;
            decimal nanoseconds = microseconds * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
