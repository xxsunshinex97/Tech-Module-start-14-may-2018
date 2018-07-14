using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4.DrawiFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Cube(n);
            /*PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            PrintMiddleRow(i);
            PrintHeaderRow(n);*/
        }

        static void Cube(int num)
        {
            PrintHeaderRow(num);
            PrintMiddleRow(num);
            PrintHeaderRow(num);
        }
        static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
        static void PrintMiddleRow(int number)
        {
            for (int j = 0; j < number - 2; j++)
            {
                Console.Write("-");
                for (int i = 0; i < number - 1; i++)
            {
                Console.Write("\\/");
            }
                Console.WriteLine("-");
            }
        }
    }
}
