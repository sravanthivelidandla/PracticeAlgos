using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class HouseRobbery
    {
        public int stealMaxWealth(int[] wealth)
        {
            int[] dp = new int[wealth.Length + 1];
            return helper(wealth, 0,dp);
        }

        int helper(int[] wealth, int index,int[] dp)
        {
            if (index >= wealth.Length)
                return 0;
            if (dp[index] != 0)
                return dp[index];
            int stealCurrent = wealth[index] + helper(wealth, index + 2,dp);

            int skipCurrent = helper(wealth, index + 1,dp);

            dp[index] = Math.Max(stealCurrent, skipCurrent);
            return dp[index];
        }
    }
}
