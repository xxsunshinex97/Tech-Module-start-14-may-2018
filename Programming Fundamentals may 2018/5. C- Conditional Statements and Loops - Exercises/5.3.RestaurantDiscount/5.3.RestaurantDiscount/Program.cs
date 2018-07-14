using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceHall = 1;
            double discount = 1;
            double pricePACK = 1;
            string Hallname = null;
            

            if (groupSize <= 50)
            {
                priceHall = 2500;
                Hallname = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                priceHall = 5000;
                Hallname = "Terrace";
            }
            else if (groupSize <= 120)
            {
                priceHall = 7500;
                Hallname = "Great Hall";
            }
            else if (groupSize > 120)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }

            if (package == "Normal")
            {
                discount = 0.05;
                pricePACK = 500;
            }
            else if (package == "Gold")
            {
                discount = 0.10;
                pricePACK = 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.15;
                pricePACK = 1000;
            }
            double totalPrice = priceHall + pricePACK;
            double promotion = totalPrice - (pricePACK*discount);
            double pricePerPerson = promotion / groupSize;

            Console.WriteLine($"We can offer you {Hallname} The price per person is {pricePerPerson}");*/

            double groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            //double priceHall = 1;
            double discount = 1;
            double pricePACK = 1;
            string Hallname = null;
            double totalPrice = 1;
            double price = 1;


            

            if (groupSize > 120)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
            else
            {
                if (groupSize > 100 && groupSize <= 120)
                {

                    //priceHall = 7500;
                    Hallname = "Great Hall";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.05;
                            pricePACK = 500;
                            break;
                        case "Gold":
                            discount = 0.1;
                            pricePACK = 750;
                            break;
                        case "Platinum":
                            discount = 0.15;
                            pricePACK = 1000;
                            break;
                    }
                    totalPrice = (7500 + pricePACK);
                    price = totalPrice - (totalPrice * discount);
                }
                else if (groupSize > 50 && groupSize <= 100 )
                {
                    //priceHall = 5000;
                    Hallname = "Terrace";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.05;
                            pricePACK = 500;
                            break;
                        case "Gold":
                            discount = 0.10;
                            pricePACK = 750;
                            break;
                        case "Platinum":
                            discount = 0.15;
                            pricePACK = 1000;
                            break;
                    }
                    totalPrice = (5000 + pricePACK);
                    price = totalPrice - (totalPrice * discount);
                }
                else if (groupSize <= 50)
                {
                    //priceHall = 2500;
                    Hallname = "Small Hall";
                    switch (package)
                    {
                        case "Normal":
                            discount = 0.05;
                            pricePACK = 500;
                            break;
                        case "Gold":
                            discount = 0.10;
                            pricePACK = 750;
                            break;
                        case "Platinum":
                            discount = 0.15;
                            pricePACK = 1000;
                            break;
                    }
                    totalPrice = (2500 + pricePACK) ;
                    price = totalPrice - (totalPrice * discount);
                }
                //totalPrice = (priceHall + pricePACK) * discount;
                double pricePerPerson = price / groupSize;

                Console.WriteLine($"We can offer you the {Hallname}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
