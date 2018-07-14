using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = (int)(24 * days);
            int minutes = (int)(60 * hours);

            Console.WriteLine($"{centuries} = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
