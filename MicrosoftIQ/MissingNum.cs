using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.MicrosoftIQ
{
    public  class MissingNum
    {
        public int SingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int missingNum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                missingNum = missingNum ^ nums[i];
            }
            return missingNum;
        }
    }
}
