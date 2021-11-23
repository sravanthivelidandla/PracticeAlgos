using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class CoinChange
    {
        public int waysToGetCoinChange(int[] denominations, int total)
        {
            int[,] dp = new int[denominations.Length, total + 1];
            return helper(denominations, total, 0,dp);
        }

        private int helper(int[] denominations, int total, int index,int[,] dp)
        {
            if (total == 0)
                return 1;

            if (index >= denominations.Length)
                return 0;

            if (dp[index, total] != 0)
            {
                return dp[index, total];
            }
            int ways1 = 0;
            if(denominations[index] <= total)
            {
                ways1 = helper(denominations, total - denominations[index], index,dp);
               
            }
            int ways2 = helper(denominations, total, index + 1,dp);
            dp[index, total] = ways1 + ways2;

            return ways1 + ways2;
        }
    }
}
