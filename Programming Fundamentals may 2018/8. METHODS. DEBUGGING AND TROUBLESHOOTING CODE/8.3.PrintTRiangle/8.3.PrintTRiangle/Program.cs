using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3.PrintTRiangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintTriangle(int n)
        {
                for (int line = 1; line <= n; line++)
                    PrintLines(1, line);
                for (int line = n - 1; line >= 1; line--)
                    PrintLines(1, line);
        }

        static void PrintLines(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
