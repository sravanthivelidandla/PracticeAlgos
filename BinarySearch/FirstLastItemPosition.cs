using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class FirstLastItemPosition
    {
        public void findItemPosition(int[] arr, int target)
        {
            int[] result = new int[] { -1, -1 };
            int answer1 = helper(arr, target,true);
            int answer2 = helper(arr, target, false);

            Console.WriteLine(answer1 + " , " + answer2);
        }

        private int helper(int[] arr, int target,bool findFirstIndex)
        {
            int ans = -1;

            int start = 0, end = arr.Length - 1;
            while(start<= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    ans = mid;
                    if (findFirstIndex)
                    {
                        end = mid - 1;
                    }
                    else
                        start = mid + 1;
                }
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }
            return ans;
        }
    }
}
