using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9.CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                count++; //брои всяко въведено нещо
                try
                {
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(count - 1); //трябва да се махне последния символ за да спре да брои тъй като не е число
                    return;
                }
            }
        }
    }
}
