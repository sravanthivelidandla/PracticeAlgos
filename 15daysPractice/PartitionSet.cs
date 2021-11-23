using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    class PartitionSet
    {

        public int canPartition(int[] num)
        {
            return this.canPartitionRecursive(num, 0, 0, 0);
        }

        private int canPartitionRecursive(int[] num, int currentIndex, int sum1, int sum2)
        {
            // base check
            if (currentIndex == num.Length)
                return Math.Abs(sum1 - sum2);

            // recursive call after including the number at the currentIndex in the first set
            int diff1 = canPartitionRecursive(num, currentIndex + 1, sum1 + num[currentIndex], sum2);

            // recursive call after including the number at the currentIndex in the second set
            int diff2 = canPartitionRecursive(num, currentIndex + 1, sum1, sum2 + num[currentIndex]);

            return Math.Min(diff1, diff2);
        }
    }
}
