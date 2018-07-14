using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MOREexercise._6.CatchThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            long parsing = 0;
            long storedParse = long.MinValue;

            for (int i = 0; i < number; i++)
            {
                parsing = long.Parse(Console.ReadLine());

                if (input == "sbyte")
                {
                    if (parsing >= sbyte.MinValue && parsing <= sbyte.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }

                else if (input == "int")
                {
                    if (parsing >= int.MinValue && parsing <= int.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }

                else if (input == "long")
                {
                    if (parsing >= long.MinValue && parsing <= long.MaxValue)
                    {
                        if (parsing > storedParse)
                        {
                            storedParse = parsing;
                        }
                    }
                }
            }
            Console.WriteLine(storedParse);
        }
    }
}
