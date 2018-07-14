using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6.ReversedArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < text.Length / 2; i++)
            {
                string temp = text[i];
                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = temp;
            }
            SwapElements(text);
        }

        static void SwapElements(string[] arr)
        {
            Console.WriteLine($"{string.Join(" ", arr)}");
        }
    }
}
