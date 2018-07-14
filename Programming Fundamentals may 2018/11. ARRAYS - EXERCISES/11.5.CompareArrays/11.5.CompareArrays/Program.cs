using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5.CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine().Split().Select(x => char.Parse(x)).ToArray();
            char[] secondLine = Console.ReadLine().Split().Select(x => char.Parse(x)).ToArray();

            int minLength = Math.Min(firstLine.Length, secondLine.Length);

            if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] > secondLine[i])
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (firstLine.Length > secondLine.Length)
                    {

                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                    }
                    else if (firstLine.Length < secondLine.Length)
                    {

                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join("", secondLine));
                            Console.WriteLine(string.Join("", firstLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstLine));
                            Console.WriteLine(string.Join("", secondLine));
                            break;
                        }
                    }
                }
            }
        }
    }
}
