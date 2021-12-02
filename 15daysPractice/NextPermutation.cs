using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class NextPermutation
    {
        //https://www.youtube.com/watch?v=IhsUbEMfIbY
        /// <summary>
        /// 
        /// </summary>
        public void getNextPermutation()
        {
            int[] nums = new int[] { 1, 8, 5, 3, 6, 2, 1 };
            getPermutation(nums).ToList().ForEach(num => Console.Write(num));
            Console.WriteLine();
            getPermutation(new int[] { 8, 7, 6, 5, 4 }).ToList().ForEach(num => Console.Write(num));
            Console.WriteLine();
            getPermutation(new int[] { 1,1,5,4,1 }).ToList().ForEach(num => Console.Write(num));
        }

        /// <summary>
        /// 1. identify the decreasing sequence
        /// 2. Identify the number to be swapped. The swapped number should be the first greatest element than i
        /// 3. reverse the other set of numbers.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int[] getPermutation(int[] nums)
        {
            //1.Identify the point where the sequence decreases
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
                i--;


            //2. Identify the element to be swapped.
            if(i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j]) 
                    j--;

                swap(nums, i, j);
            }

            //.Arrange the elements in the reverse order.
            reverse(nums, i + 1);

            return nums;
        }

        private void reverse(int[] nums, int start)
        {
            int end = nums.Length - 1;
            while(start < end)
            {
                swap(nums, start, end);
                start++;
                end--;
            }
        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
