using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class StairsToBeTaken
    {
        public int CountWays(int n)
        {
            // TODO: Write your code here
            int[] dp = new int[n + 1];
            return helper(n,dp);
        }

        int helper(int n,int[] dp)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            if (dp[n] <= 0)
            {
                int ways1 = helper(n - 1,dp);
                int ways2 = helper(n - 2,dp);
                int ways3 = helper(n - 3,dp);

                dp[n] = ways1 + ways2 + ways3;
            }
            return dp[n];
        }
    }
}
