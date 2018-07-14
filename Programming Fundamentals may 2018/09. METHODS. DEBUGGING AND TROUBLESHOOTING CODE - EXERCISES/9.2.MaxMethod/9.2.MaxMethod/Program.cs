using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        static int GetMax(int a, int b, int c)
        {
            int result = Math.Max(Math.Max(a, b), c);
            return result;
        }
    }
}
