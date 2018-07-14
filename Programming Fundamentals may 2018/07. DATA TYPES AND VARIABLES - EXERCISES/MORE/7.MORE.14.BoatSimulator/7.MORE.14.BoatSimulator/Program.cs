using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            byte positionBoat1 = 0;
            byte positionBoat2 = 0;

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                if (command == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        positionBoat1 += (byte)command.Length;
                        if (positionBoat1 >= 50)
                        {
                            break;
                        }
                    }
                    else
                    {
                        positionBoat2 += (byte)command.Length;
                        if (positionBoat2 >= 50)
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(positionBoat1 > positionBoat2 ? firstBoat : secondBoat);
        }
    }
}
