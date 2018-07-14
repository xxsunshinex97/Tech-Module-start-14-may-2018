using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4.SplitWOrdCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string separators = ",;:.!()\"'\\/[] "; // използва се \ пред " за да се разпознаят

            string input = Console.ReadLine();
            List<string> lowerCase = new List<string>();
            List<string> upperrCase = new List<string>();
            List<string> mixedCase = new List<string>();

            string[] inputSplit = input.Split(separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < inputSplit.Length; i++)
            {
                if (isCase(inputSplit[i], "upper"))
                {
                    upperrCase.Add(inputSplit[i]);
                }
                else if (isCase(inputSplit[i], "lower"))
                {
                    lowerCase.Add(inputSplit[i]);
                }
                else
                {
                    mixedCase.Add(inputSplit[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperrCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
        }

        static bool isCase(string value, string isCase)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if ((!char.IsLetter(value[i]) || char.IsDigit(value[i])) || (isCase.ToLower() == "upper" && char.IsLower(value[i])) || (isCase.ToLower() == "lower" && char.IsUpper(value[i])))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
