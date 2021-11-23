using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class RodCutting
    {
        public int rodCutting(int[] prices, int[] lengths, int rodLength)
        {
            return rodCuttingRecursive(prices, lengths, rodLength,0);
        }

        private int rodCuttingRecursive(int[] prices, int[] lengths, int rodLength,int index)
        {
            if (index >= prices.Length || rodLength == 0)
                return 0;

            int profit1 = 0;
            if(lengths[index] <= rodLength)
            {
                profit1 = prices[index] + rodCuttingRecursive(prices, lengths, rodLength - lengths[index], index);
            }

            int profit2 = rodCuttingRecursive(prices, lengths, rodLength, index + 1);

            return Math.Max(profit1, profit2);
        }
    }
}
