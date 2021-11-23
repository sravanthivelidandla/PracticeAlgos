using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class MinCoinChange
    {
        public int minCoinChange(int[] denominations, int target)
        {
            int index = 0;
            int result = helper(denominations, target, index);
            return result != int.MaxValue ? result : -1;
        }

        private int helper(int[] denominations, int target, int index)
        {
            if (target == 0)
                return 1;
            if (denominations.Length == 0 || index >= denominations.Length)
                return int.MaxValue;

            int count1 = 0;
            if(denominations[index] <= target)
            {
              int  ways1 = helper(denominations, target - denominations[index], index);
                if (ways1 != int.MaxValue)
                    count1 = ways1 + 1;
            }
            int count2 = helper(denominations, target, index + 1);
            return Math.Min(count1, count2);
        }
    }
}
