using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1.CommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            

            Console.WriteLine(LargestCommandEnd(arr1, arr2));
        }

        static int LargestCommandEnd(string[] arr1, string[] arr2)
        {
            int minLength = arr1.Length <= arr2.Length ? arr1.Length : arr2.Length;
            int largestCommand1 = 0;
            int largestCommand2 = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    largestCommand1++;
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    largestCommand2++;
                }
                else
                {
                    break;
                }
            }
            return largestCommand1 >= largestCommand2 ? largestCommand1 : largestCommand2;
        }
    }
}
