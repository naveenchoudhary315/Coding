using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    internal class BuyAndSellStocks
    {
        //Best Time to Buy and Sell Stock Problem

        public void MaxProfit()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int bestBuy = prices[0];       // bestBuy starts with the first price.
            int maxProfit = 0;             //  maxProfit starts at 0 because we haven't made any transaction yet.

            foreach (int currentPrice in prices)
            {
                if (currentPrice > bestBuy) // if current price is greater than bestBuy, we can calculate potential profit.
                {
                    maxProfit = Math.Max(maxProfit, currentPrice - bestBuy);
                }
                else  // if currentprice < bestBuy then set bestBuy = currentPrice because it should be awlays smaller value.
                {
                    bestBuy = Math.Min(bestBuy, currentPrice); // if current price is less than or equal to bestBuy, we update bestBuy to the lower price. 
                }
            }

            Console.WriteLine(maxProfit);
        }
    }
}
