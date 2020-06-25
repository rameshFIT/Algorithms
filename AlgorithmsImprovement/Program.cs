using System;

namespace AlgorithmsImprovement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] priceArray = new int[] { 7, 8, 1, 7, 5 };
            GetMaxProfit(priceArray);
            //start time 5:56PM
            //end time 6:41PM
        }

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
