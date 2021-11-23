using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class UnboundedKnapsack
    {
        public int solveKnapsack(int[] profits, int[] weights, int capacity)
        {
            int[,] dp = new int[profits.Length, capacity+1];
            return solveKanpsackHelper(profits, weights, capacity, 0,dp);
        }

        private int solveKanpsackHelper(int[] profits, int[] weights, int capacity, int index,int[,] dp)
        {
            if (index == weights.Length || capacity <= 0)
                return 0;


            if(dp[index,capacity] > 0)
            {
                return dp[index, capacity];
            }

            int profit1 = 0;
            if(weights[index] <= capacity)
            {
                profit1 = profits[index] + solveKanpsackHelper(profits, weights, capacity-weights[index], index , dp);
                dp[index, capacity] = profit1;

            }

            int profit2 = solveKanpsackHelper(profits, weights, capacity, index + 1,dp);
            dp[index, capacity] = profit2;

            return Math.Max(profit1, profit2);
        }
    }
}
