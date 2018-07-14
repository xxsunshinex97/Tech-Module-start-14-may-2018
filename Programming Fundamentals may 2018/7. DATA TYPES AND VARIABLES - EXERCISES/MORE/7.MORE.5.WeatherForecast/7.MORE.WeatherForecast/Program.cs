using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                sbyte.Parse(numberString);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(numberString);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(numberString);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(numberString);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }


            /*string input = Console.ReadLine();
            signed long number = _int64.Parse(input);

            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (number >= int.MinValue && number <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
            else if (number >= double.MinValue && number <= double.MaxValue)
            {
                Console.WriteLine("Rainy");
            } */
        }
    }
}
