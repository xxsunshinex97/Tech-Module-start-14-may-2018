using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2.RotateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];

            for (int i = 0; i < n; i++)
            {
                RotateRight(arr, sum);
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static void RotateRight(int[] arr, int[] sum)
        {
           // int count = 0;
            //while (count < arr.Length)
           // {
                int temp = arr[arr.Length - 1];

                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = temp;
                //count++;

                for (int i = 0; i < arr.Length; i++)
                {
                    sum[i] += arr[i];
                }
            //}

        }

    }
}
