using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class MaxConsecutive1s
    {
        public void maxConsecutive1s()
        {
            int[] nums = { 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 };
            Console.WriteLine("value = {0}", solveMax1s(nums, 2));

            Console.WriteLine(solveMaxChars("AABAAABB".ToCharArray(), 2));
        }

        int solveMax1s(int[] nums, int flipCount)
        {
            int maxLength = 0;
            int low = 0;
            int high = 0;

            while (high <  nums.Length)
            {
                if(nums[high] == 1)
                {
                    high++;
                    continue;
                }

                if(nums[high] == 0 && flipCount > 0)
                {
                    high++;
                    flipCount--;
                    continue;
                }

                if(nums[high] == 0 && flipCount == 0)
                {
                    maxLength = Math.Max(maxLength, high - low);
                    while (low < high && flipCount == 0)
                    {
                        if (nums[low] == 0)
                            flipCount++;
                        low++;
                    }
                }
            }

            return Math.Max(maxLength, high - low);
        }

        int solveMaxChars(char[] nums, int flipCount)
        {
            int maxLength = 0;
            int low = 0;
            int high = 0;

            while (high < nums.Length)
            {
                if (nums[high] == 'A')
                {
                    high++;
                    continue;
                }

                if (nums[high] == 'B' && flipCount > 0)
                {
                    high++;
                    flipCount--;
                    continue;
                }

                if (nums[high] == 'B' && flipCount == 0)
                {
                    maxLength = Math.Max(maxLength, high - low);
                    while (low < high && flipCount == 0)
                    {
                        if (nums[low] == 'B')
                            flipCount++;
                        low++;
                    }
                }
            }

            return Math.Max(maxLength, high - low);
        }
    }
}
