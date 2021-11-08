using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day6
{
    public class Permutations
    {

        public List<List<int>> getPermutations(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();
            generatePermsRecursively(nums, 0, new List<int>(), result);
            return result;
        }

        private void generatePermsRecursively(int[] nums, int index, List<int> curPerm, List<List<int>> result)
        {
            if(index == nums.Length)
            {
                result.Add(curPerm);
            }
            else
            {
                for(int i =0; i<= curPerm.Count; i++)
                {
                    List<int> newPerm = new List<int>(curPerm);
                    newPerm.Insert(i, nums[index]);
                    generatePermsRecursively(nums, index + 1, newPerm, result);

                }
            }
        }

        public List<List<string>> permutationsForString(string input)
        {
            List<List<string>> result = new List<List<string>>();
            generatePermutationsForString(input.ToCharArray(), 0, new List<string>(), result);
            return result;
        }

        private void generatePermutationsForString(char[] input, int index, List<string> curPerm,List<List<string>> result)
        {
            if(index == input.Length)
            {
                result.Add(curPerm);
            }
            else
            {
                for(int i =0; i<= curPerm.Count; i++)
                {
                    List<string> newPermutation = new List<string>(curPerm);
                    newPermutation.Insert(i, input[index].ToString());
                    generatePermutationsForString(input, index + 1, newPermutation, result);
                }
            }
        }

        public string printNumberName(int inputNumber)
        {
            StringBuilder numberName = new StringBuilder();

            //define the constants. from  one to ten
            //define the constants for twenty to thirty
            //define hundred, thousand, lkahs, millions, crores.

            if (inputNumber < 0) {
                return "";
            }
            else if (inputNumber == 0)
                return "zero";
            else {
                int crores = (inputNumber / 1000000);
                numberName.Append(getPlaceValue(crores) + "crores");

                int lakhs = (inputNumber / 100000);
            }

            return "";
        }

        private string getPlaceValue(int number) {
            if (number > 0)
                return "number name";
            else
                return "";
        }
    }

}
