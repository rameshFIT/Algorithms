using System;

namespace AlgorithmsImprovement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] priceArray = new int[] { 7, 8, 1, 7, 5 };
            //GetMaxProfit(priceArray);
            //start time 5:56PM
            //end time 6:41PM

            PluralCourseTimeIntoEstimates.PerformPluralEstimateOperation();
            Console.ReadLine();
        }




        /*Say you have an array for which the nth element is the price of a given day n.
        If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), 
        design an algorithm to find the maximum profit. Note that you cannot sell a stock before you buy one.
        Example 1) 
        Input: {7,1,5,3,6,4}
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        Not 7-1 = 6, as selling price needs to be larger than buying price. */

        private static void GetMaxProfit(int[] inputPrices)
        {
            int highestProfitNumber = 0;
            for (int i = 0; i < inputPrices.Length-1; i++)
            {
                int outerNumber = inputPrices[i];               
                for (int y = i+1; y < inputPrices.Length; y++)
                {
                    var innerNumber = inputPrices[y];
                    if (innerNumber > outerNumber)
                    {
                       var currentNumberDifference = innerNumber - outerNumber;
                        if(currentNumberDifference > highestProfitNumber)
                        {
                            highestProfitNumber = currentNumberDifference;
                        }
                    }
                }               
            }
            Console.WriteLine($"Highest Profit is {highestProfitNumber}");
            Console.ReadLine();
        }
    }
}
