using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos.PalindromicStrings
{
    public class LPS //Longest PAlindromic SubSequence. // this can be non adjacent
    {
        public int lps(string s)
        {
            int[,] dp = new int[s.Length, s.Length];
            return lpsHelper(s, 0, s.Length-1,dp);
        }

        int lpsHelper(string input, int startIndex, int endIndex,int[,] dp)
        {
            if (startIndex > endIndex)
                return 0;

            if (startIndex == endIndex)
                return 1;

            if (dp[startIndex, endIndex] > 0)
                return dp[startIndex, endIndex];
            
            if(input[startIndex] == input[endIndex])
            {
                return 2 + lpsHelper(input, startIndex + 1, endIndex - 1,dp);
            }

            int c1 = lpsHelper(input, startIndex + 1, endIndex,dp);
            int c2 = lpsHelper(input, startIndex, endIndex - 1,dp);

            dp[startIndex,endIndex] = Math.Max(c1, c2);
            return dp[startIndex, endIndex];
        }
    }
}
