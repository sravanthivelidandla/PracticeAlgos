using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class Ceiling
    {
        public void ceilingOfNum(int[] arr,int target)
        {
            Console.WriteLine(ceilingHelper(arr, target, 0, arr.Length - 1));
        }

        private int ceilingHelper(int[] arr,int target, int start, int end)
        {
            int mid = (start + end) / 2;

            if (arr[mid] == target)
                return arr[mid];

            if(start == end + 1)
            {
                return arr[start];
            }

            if(target > arr[mid])
            {
                return ceilingHelper(arr, target, mid + 1, end);
            }
            return ceilingHelper(arr, target, start, mid - 1);
        }
    }
}
