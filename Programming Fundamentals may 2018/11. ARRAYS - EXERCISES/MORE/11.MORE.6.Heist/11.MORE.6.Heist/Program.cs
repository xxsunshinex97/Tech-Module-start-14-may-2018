using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MORE._6.Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //first line
            string[] input = Console.ReadLine().Split(' ');
            int jewelPrice = int.Parse(input[0]); //10
            int goldPrice = int.Parse(input[1]); //20

            //second line
            string commands;
            //string loot; commandArgs[0]
            //long expenses = 0; commandArgs[1]


            //calculating variables
            //int jewelsQuantity = 0;
            //int goldQuantity = 0;
            //long totalHeistAmount = 0;
            //long totalJewel = 0;
            //long totalGold = 0;
            long totalExpenses = 0;
            long totalMoney = 0;


            while ((commands = Console.ReadLine()) != "Jail Time") // DaS@!%$$ 40
            {
                int jewelsQuantity = 0;
                int goldQuantity = 0;

                string[] commandArgs = commands.Split(' ');
                string loot = commandArgs[0];
                long expenses = long.Parse(commandArgs[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        jewelsQuantity++;
                    }
                    else if (loot[i] == '$')
                    {
                        goldQuantity++;
                    }
                }
                totalExpenses += expenses;

                long totalJewel = jewelPrice * jewelsQuantity;
                long totalGold = goldPrice * goldQuantity;

                long totalHeistAmount = totalJewel + totalGold;
                totalMoney += totalHeistAmount;
            }
            Console.WriteLine(totalMoney >= totalExpenses ? $"Heists will continue. Total earnings: {Math.Abs(totalMoney - totalExpenses)}." : $"Have to find another job. Lost: {Math.Abs(totalExpenses - totalMoney)}.");
        }
    }
}
