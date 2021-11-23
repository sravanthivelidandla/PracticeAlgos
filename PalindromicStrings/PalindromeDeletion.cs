using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.PalindromicStrings
{
    public class PalindromeDeletion
    {
        public int minDeletions(string s)
        {
            return s.Length - helper(s, 0, s.Length - 1);
        }

        int helper(string input, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return 0;

            if (startIndex == endIndex)
                return 1;

            if(input[startIndex] == input[endIndex])
            {
                return 2 + helper(input, startIndex + 1, endIndex - 1);
            }

            int c1 = helper(input, startIndex + 1, endIndex);
            int c2 = helper(input, startIndex, endIndex - 1);

            return Math.Max(c1, c2);
        }
    }
}
