using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeter = int.Parse(Console.ReadLine());
            float hours = int.Parse(Console.ReadLine());
            float minutes = int.Parse(Console.ReadLine());
            float seconds = int.Parse(Console.ReadLine());

            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds); //превръщаме цялото време в секунди

            float meterPerSecond = (float)distanceMeter / time;
            float kilometersPerHour = ((float)distanceMeter/ 1000) / ((float)time / 3600); // секунди / 3600 = часове
            float milesPerHour = ((float)distanceMeter / 1609) / ((float)time / 3600);

            Console.WriteLine($"{meterPerSecond}\n{kilometersPerHour}\n{milesPerHour}");
        }
    }
}
