using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class JumpGameII
    {
        public int MinJumpsRequired(int[] nums)
        {
            int numJumps = 0, currentJumpEnd = 0, farthest = 0;

            for(int i = 0; i< nums.Length; i++)
            {
                if (i > farthest)
                    return -1;
                
                farthest = Math.Max(farthest, i + nums[i]);

                if(i == currentJumpEnd)
                {
                    numJumps++;
                    currentJumpEnd = farthest;
                }
            }
            return numJumps;
        }
    }
}
