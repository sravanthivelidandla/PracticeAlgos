using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class RotatedSortedArray
    {
        public int search(int[] arr, int target)
        {
            return searchHelper(arr, target, 0, arr.Length - 1);
        }

        private int searchHelper(int[] arr, int target, int start, int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) / 2;
            if (arr[mid] == target)
                return mid;
            if(target < arr[mid] && target > arr[start])
            {
                return searchHelper(arr, target, start, mid - 1);
            }
            else if(target > arr[mid] && target < arr[end])
            {
                return searchHelper(arr, target, start + 1, end);
            }

            if(target > arr[start])
            {
                return searchHelper(arr, target, start, mid - 1);
            }
            else
            {
                return searchHelper(arr, target, mid + 1, start);
            }

            return -1;
        }
    }
}
