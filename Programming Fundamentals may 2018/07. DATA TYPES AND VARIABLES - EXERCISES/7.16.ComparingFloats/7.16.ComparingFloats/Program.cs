using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(num1 - num2) < eps) //извежда абсолютната стойност на double
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            /*float f1 = 1.0f / 6.0f;
            float f2 = (f1 * 6.0f) - 1.0f;   // Should be 0.0
            float f3 = 0.0f;

            bool check = (f2 == f3);       // false !
            check = NearlyEqual(f2, f3);   // true
        
        public static bool NearlyEqual(float f1, float f2)
        {
            // Equal if they are within 0.00001 of each other
            return Math.Abs(f1 - f2) < 0.00001;
        }*/
        }
    }
}
