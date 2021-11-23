using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //https://leetcode.com/problems/word-break/discuss/615636/c-dp-solution
    public class WordBreak
    {
        public bool wordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            bool[] dp = new bool[s.Length + 1];

            dp[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {   
                    if (dp[j] && wordDict.Contains(s.Substring(j, i-j)))
                    {                        
                        dp[i] = true;                      
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
