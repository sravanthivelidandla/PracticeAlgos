using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class Floor
    {
        public void floorOfNumber(int[] arr, int target)
        {
            Console.WriteLine(floorHelper(arr, target, 0, arr.Length-1));
        }

        private int floorHelper(int[] arr, int target, int start, int end)
        {
            int mid = (start + end) / 2;
            if (arr[mid] == target)
                return arr[mid];

            if (start == end + 1)
                return arr[end];

            if(target < arr[mid])
            {
                return floorHelper(arr, target, start, mid - 1);
            }
            return floorHelper(arr, target, mid + 1, end);
        }
    }
}
