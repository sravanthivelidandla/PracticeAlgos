using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public  class FindIndexOfItem
    {
        public void findIndex(int[] arr, int target)
        {
           List<int> output =  helper(arr, target, 0);
            output.ForEach(item => Console.WriteLine(item));
        }

        private List<int> helper(int[] arr, int target, int index)
        {
            List<int> targets = new List<int>();
            if (index == arr.Length)
                return targets;

            if (arr[index] == target)
                targets.Add(index);

            List<int> answers = helper(arr, target, index + 1);
            targets.AddRange(answers);

            return targets;
        }
    }
}
