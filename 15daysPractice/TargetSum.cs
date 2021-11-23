using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class TargetSum
    {
        public int targetSum(int[] nums, int target)
        {
            Dictionary<(int,int), int> dp = new Dictionary<(int,int), int>();
            return helper(nums, target, 0, 0,dp);
        }

        public int helper(int[] nums, int target, int sum, int index, Dictionary<(int,int), int> dp)
        {
            if (index == nums.Length)
            {
                if (!dp.ContainsKey((index,sum)))
                {
                    if (target == sum)
                        dp[(index,sum)] = 1;
                    else
                        dp[(index, sum)] = 0;
                }
                return dp[(index, sum)];

            }
            else if(index > nums.Length)
                return 0;

            if (dp.ContainsKey((index, sum)))
                return dp[(index, sum)];

            dp[(index, sum)] = helper(nums, target, sum + nums[index], index + 1,dp) + helper(nums, target, sum - nums[index], index + 1,dp);
            return dp[(index, sum)];
        }
    }
}
