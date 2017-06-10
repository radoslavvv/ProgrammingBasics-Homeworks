using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = GetDifference(lastPrice, currentPrice);
            bool hasDiff = HasSignificantDiff(difference, threshold);

            string message = GetMessage(currentPrice, lastPrice, difference, hasDiff);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference, bool hasSignificantDiff)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!hasSignificantDiff)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (hasSignificantDiff && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (hasSignificantDiff && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        
       

        return message;
    }
    private static bool HasSignificantDiff(double difference, double significantDiff)
    {
        if (Math.Abs(difference / 100) >= significantDiff)
        {
            return true;
        }
        return false;
    }

    private static double GetDifference(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice * 100;
        return result;
    }
}
