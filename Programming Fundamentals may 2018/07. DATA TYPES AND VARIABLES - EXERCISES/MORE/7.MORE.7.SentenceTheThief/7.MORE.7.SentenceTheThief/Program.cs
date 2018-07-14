using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MORE._7.SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            sbyte n = sbyte.Parse(Console.ReadLine());
            long maxnumber = long.MinValue;
            for (int i = 1; i <= n; i++)
            {
                var number = long.Parse(Console.ReadLine());
                switch (type)
                {
                    case "sbyte":
                        if (number <= sbyte.MaxValue && number > maxnumber)
                        {
                            maxnumber = number;
                        }
                        break;
                    case "int":
                        if (number <= int.MaxValue && number > maxnumber)
                        {
                            maxnumber = number;
                        }
                        break;
                    case "long":
                        if (number <= long.MaxValue && number > maxnumber)
                        {
                            maxnumber = number;
                        }
                        break;
                }
            }
            long sentence = 0;
            if (maxnumber >= 0)
            {
                sentence = (long)Math.Ceiling(Math.Abs((decimal)maxnumber / sbyte.MaxValue));
            }
            else
            {
                sentence = (long)Math.Ceiling(Math.Abs((decimal)maxnumber / sbyte.MinValue));
            }
            if (Math.Abs(sentence) <= 1)
            {
                Console.WriteLine($"Prisoner with id {maxnumber} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {maxnumber} is sentenced to {sentence} years");
            }
            /*string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            long parsing = 0;
            long storedParse = long.MinValue;
            long sentence = 0;

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
            //Console.WriteLine($"{Math.Floor(sentence)}");

            if (storedParse >= 0)
            {
                sentence = (long)Math.Ceiling(Math.Abs((decimal)storedParse / int.MaxValue));
            }
            else
            {
                sentence = (long)Math.Ceiling((Math.Abs((decimal)storedParse / sbyte.MinValue)));
            }

            if (Math.Abs(sentence) <= 1)
            {
                Console.WriteLine($"Prisoner with id {storedParse} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {storedParse} is sentenced to {sentence} years");
            }*/
        }
    }
}
    
