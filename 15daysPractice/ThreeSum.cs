using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class ThreeSum
    {
        /// <summary>
        /// Sort the array. O(n^2)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<List<int>> threeSum(int[] nums, int target)
        {
            List<List<int>> result = new List<List<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || nums[i-1] != nums[i])
                {
                    twoSum(nums, i,result, target);
                }
            }
            return result;
        }

        private void twoSum(int[] nums, int i ,List<List<int>> result, int target)
        {
            int low = i + 1, high = nums.Length - 1;
            while(low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if(sum < target)
                {
                    low++;
                }
                else if(sum > target)
                {
                    high--;
                }
                else
                {
                    result.Add(new List<int>() { nums[i], nums[low], nums[high] });
                    while(low < high && nums[low + 1] == nums[low])
                    {
                        low++;
                    }
                    high--;
                }
            }
        }
    }
}
