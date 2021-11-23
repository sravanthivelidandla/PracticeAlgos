using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class TwoSum
    {
        /// <summary>
        /// Sorted array is given as the input. Use two pointer method
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool twoSumII(int[] nums,int target)
        {
            int low = 0 , high = nums.Length - 1;
            while(low < high)
            {
                int sum = nums[low] + nums[high];
                if (sum < target)
                    low++;
                else if (sum > target)
                {
                    high--;
                }
                else
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Method to check if the two sum is possible.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i =0; i< nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (dic.ContainsKey(nums[i]))
                {
                    return new int[] { i, dic[nums[i]] };
                }
                else
                    dic[compliment] = i;
            }
            return new int[] {};
        }
    }
}
