using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class MountainArray
    {
        public int findIndex(int[] arr)
        {
            return findIndexHelper(arr,0, arr.Length -1);
        }

        private int findIndexHelper(int[] arr, int start,int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) / 2;
            if (arr[mid] > arr[mid + 1] && arr[mid - 1] < arr[mid])
            {
                return mid;
            }
            else if (arr[start] < arr[mid])
                return findIndexHelper(arr, mid + 1, end);
            else
                return findIndexHelper(arr, start, mid - 1);            
        }

        public int findElement(int[] arr)
        {
            int index =  findIndexHelper(arr, 0, arr.Length - 1);
            return index > 0 ?  arr[index] : -1;
        }

        public int SearchElement(int[] arr,int target)
        {
            int peak = findIndexHelper(arr, 0, arr.Length - 1);
            int result = findIndexHelper(arr, target, 0, peak);
            if (result == -1)
                 result = findIndexHelper(arr, target, peak + 1, arr.Length);
            return result;
        }

        private int findIndexHelper(int[] arr,int target, int start, int end)
        {
            if (start > end)
                return -1;
            int mid = (start + end) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[start] < arr[mid])
                return findIndexHelper(arr, mid + 1, end);
            else
                return findIndexHelper(arr, start, mid - 1);
        }

    }
}
