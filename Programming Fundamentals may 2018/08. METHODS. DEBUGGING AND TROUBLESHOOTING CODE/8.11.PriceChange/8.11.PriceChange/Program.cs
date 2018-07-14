using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._11.PriceChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double newPrice = double.Parse(Console.ReadLine());
                double difference = Percentage(lastPrice, newPrice);

                bool isSignificantDifference = isDifferent(difference, significanceThreshold);

                string message = GetMessage(newPrice, lastPrice, difference, isSignificantDifference);
                lastPrice = newPrice;
                Console.WriteLine(message);
            }
        }

        private static string GetMessage(double newPrice, double lastPrice, double difference, bool etherTrueOrFalse)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (!etherTrueOrFalse)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, difference * 100);
            return message;
        }
        private static bool isDifferent(double significanceThreshold, double isDiff)
        {
            if (Math.Abs(significanceThreshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double oldPrice, double newPrice)
        {
            double percentage = (newPrice - oldPrice) / oldPrice;
            return percentage;
        }
    }
}
