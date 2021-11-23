using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //https://www.youtube.com/watch?v=muDPTDrpS28
    public class JumpGameI
    {
        public bool canJump(int[] n)
        {
            int reachable = 0;
            for(int i =0; i< n.Length; i++)
            {
                if (i > reachable)
                    return false;
                reachable = Math.Max(reachable, i + n[i]);
            }
            return true;
        }
        
    }
}
