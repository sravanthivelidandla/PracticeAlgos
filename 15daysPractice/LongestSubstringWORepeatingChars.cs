using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    /// <summary>
    /// Use sliding window technique
    /// https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/22188594#overview
    /// </summary>
    public class LongestSubstringWORepeatingChars
    {
        public void getLengthOfLongestSubstring()
        {
            string input = "wkekwperkws";

            int left = 0, longest = 0;
            Dictionary<char, int> seenCharPosition = new Dictionary<char, int>();
            for(int right = 0; right < input.Length; right++)
            {
                char ch = input[right];

                if (seenCharPosition.ContainsKey(ch))
                {
                    int seenPosition = seenCharPosition[ch];
                    if (seenPosition >= left)
                    {
                        left = seenPosition + 1;
                    }
                    seenCharPosition[ch] = right;
                }
                else
                    seenCharPosition.Add(ch, right);

                
                longest = Math.Max(longest, right - left + 1);
            }

            Console.WriteLine("length of the longest substring = {0}", longest);
        }
    }
}
