using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class MaxRibbonCut
    {
        public int maxRibbonCutSolver(int[] ribbonLengths, int targetLength)
        {
            int result = int.MinValue;
            result = helper(ribbonLengths, targetLength, 0);
            if (result == int.MinValue)
                return -1;
            else
                return result;
        }

        private int helper(int[] ribbonLengths, int targetLength, int index)
        {
            if (targetLength == 0)
                return 0;
            if (ribbonLengths.Length == 0 || index >= ribbonLengths.Length)
                return int.MinValue;

            int count1 = int.MinValue;
            if(ribbonLengths[index] <= targetLength)
            {
                int res = helper(ribbonLengths, targetLength - ribbonLengths[index], index);
                if (res != int.MinValue)
                    count1 = res + 1;
            }
            int count2 = helper(ribbonLengths, targetLength, index + 1);
            return Math.Max(count1, count2);    
        }
    }
}
