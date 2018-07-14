using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._13.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            //char letter = char.Parse(Console.ReadLine());
            string message = "";

            while (n > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                n--;
            }
            Console.WriteLine(message);
        }
    }
}
