using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos.BinarySearch
{
    public class NextGreatestLetter
    {
        public void nextGreatestLetter(char[] arr, char target)
        {
            Console.WriteLine( helper(arr, target, 0, arr.Length - 1));
        }

        private char helper(char[] arr, char target, int start, int end)
        {
            int mid = (start + end) / 2;

            if(start == end + 1)
            {
                return arr[start % (arr.Length)];
            }

            if (target < arr[mid])
            {
                return helper(arr, target, start, mid - 1);
            }
            else
                return helper(arr, target, mid + 1, end);

            
        }
    }
}
