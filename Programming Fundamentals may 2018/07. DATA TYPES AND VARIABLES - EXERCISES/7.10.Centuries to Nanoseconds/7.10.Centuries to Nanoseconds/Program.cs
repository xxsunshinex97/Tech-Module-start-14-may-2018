using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = 100 * century;
            int days = (int)(years * 365.2422);
            long hours = 24 * days;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            long miliseconds = 1000 * seconds;
            long microseconds = 1000 * miliseconds;
            decimal nanoseconds = 1000m * microseconds; //задължително се добавя m

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
