using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._10.SumChars
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());

            int sum = 0;
            //decimal j = 0;

            for (int i = 0; i < n; i++)
            {
                //char letter = char.Parse(Console.ReadLine());

                //decimal vOut = Convert.ToDecimal(letter); //Unable to cast object of type 'System.Char[]' to type 'System.IConvertible'
                //string result = Convert.ToString(vOut);

                //i = (int)char.GetNumericValue(letter);
                //i = (int)letter;
                //j = (decimal)letter;

                sum += char.Parse(Console.ReadLine());
                n--;
            }
            Console.WriteLine(sum);*/

            byte charsCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (charsCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charsCount--;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
