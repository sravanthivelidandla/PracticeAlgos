using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.PalindromicStrings
{
    public class LPSubstring // this should be contiguous. or adjacent
    {
        public int lpSubstring(string input)
        {
            return helper(input, 0, input.Length-1);
        }

        private int helper(string input, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return 0;

            if (startIndex == endIndex)
                return 1;

            if(input[startIndex] == input[endIndex])
            {
                int remainingLength = endIndex - startIndex - 1;
                if (remainingLength == helper(input, startIndex+1, endIndex-1))
                    return 2 + remainingLength;
            }

            int c1 = helper(input, startIndex + 1, endIndex);
            int c2 = helper(input, startIndex, endIndex - 1);

            return Math.Max(c1, c2);
        }
    }
}
