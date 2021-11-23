using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //https://www.youtube.com/channel/UC5IRvrPQcouPsO942OLNwVg/videos -- from knapsack
    public  class DecodeWays
    {
        public int decodeWays(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            int[] memo = new int[input.Length];
            for(int i =0; i < input.Length; i++)
            {
                memo[i] = -1;
            }
            return helper(input.ToCharArray(), input.Length - 1,0,memo);
        }

        public int helper(char[] input, int i, int ways, int[] memo)
        {
            if (i == 0)
            {
                if (input[i] == '0')
                {
                    memo[i] = 0;
                    return 0;
                }
                else
                {
                    memo[i] = 1;
                    return 1;
                }
            }

            if (i == -1)
            {               
                return 1;
            }

            if (input[i] == '0')
            {
                if (input[i - 1] == '1' || input[i - 1] == '2')
                {
                    if (memo[i] == -1)
                    {
                        memo[i] = helper(input, i - 2, ways, memo);
                    }
                    return memo[i];
                }

                else
                    return 0;
            }
            if ((input[i - 1] == '1' || input[i - 1] == '2') && ((int)(input[i] - '0') < 7))
            {
                if (memo[i] == -1)
                {
                    ways = helper(input, i - 1, ways, memo) + helper(input, i - 2, ways, memo);
                    memo[i] = ways;
                }else
                ways = memo[i];
            }
            else
            {
                if (memo[i] == -1)
                {
                    ways = helper(input, i - 1, ways, memo);
                    memo[i] = ways;
                }
                else
                    ways = memo[i];
            }  

            return ways;
        }

        public int decodeWaysII(string input)
        {
            int[] dp = new int[input.Length + 1];
            char[] inputChars = input.ToCharArray();
            dp[0] = 1;
            if (inputChars[0] == '0')
                return 0;
            else
            dp[1] = 1;

            for(int i =2; i <= input.Length; i++)
            {
                if(inputChars[i-1] == '0')
                {
                    if (inputChars[i - 2] == '1' || inputChars[i - 2] == '2')
                        dp[i] = dp[i - 2];
                    else
                    {
                        return 0;
                    }
                }               
                else {
                    if (inputChars[i - 2] == '1' || inputChars[i - 2] == '2' && Convert.ToInt16(inputChars[i - 1] - '0') < 7)
                    {
                        dp[i] = dp[i - 1] + dp[i - 2];
                    }
                    else
                    {
                        dp[i] = dp[i - 1];
                    }
                }
            }
            return dp[input.Length];
        }
    }
}
