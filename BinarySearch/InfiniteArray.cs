using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class InfiniteArray
    {
        public int positionOfItem(int[] array, int target)
        {
            //box sze
            int start = 0;
            int end = 1;
            while(target > array[end])
            {
                int newStart = end + 1;
                end = end+ (end - start + 1) * 2;
                start = newStart;
            }

            return searchItem(array, target, start, end);
        }

        public int searchItem(int[] array, int target, int start,int end)
        {
            while(start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] == target)
                    return mid;
                else if (target > array[mid])
                {
                    start = mid + 1;
                }
                else
                    end = mid - 1;
            }
            return -1;
        }
    }
}
