using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.PalindromicStrings
{
    public class MinimumPalindromeCuts
    {
        public int mpCuts(string s)
        {
            return helper(s, 0, s.Length - 1);
        }

        private int helper(string input, int startIndex, int endIndex)
        {
            //I dont need any cuts if the string is palindrome.
            if (startIndex >= endIndex || isPalindrome(input, startIndex, endIndex))
                return 0;

            int minCuts = endIndex - startIndex;

            for(int i = startIndex; i< endIndex;i++)
            {
                if (isPalindrome(input, startIndex, i))
                {
                    minCuts = Math.Min(minCuts, 1+ helper(input, i + 1, endIndex));
                }
            }
            return minCuts;
        }

        bool isPalindrome(string input, int startIndex, int endIndex)
        {
            while(startIndex < endIndex)
            {
                if (input[startIndex++] != input[endIndex--])
                    return false;
            }
            return true;
        }
    }
}
