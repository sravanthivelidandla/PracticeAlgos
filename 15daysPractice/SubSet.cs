using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class SubSet
    {
        public void printSubset(string input)
        {
            List<string> result = helper2(input, "", new List<string>());
            result.ForEach(x => { Console.WriteLine(x); });
        }

        private void helper(string input, string output)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(output);
                return;
            }

            helper(input.Substring(1), output + input[0]);
            helper(input.Substring(1), output);
        }


        private List<string> helper2(string input, string output, List<string> result)
        {
            if (string.IsNullOrEmpty(input))
            {
                result.Add(output);
                return result;
            }
            helper2(input.Substring(1), output + input[0], result);
            helper2(input.Substring(1), output, result); 
            helper2(input.Substring(1),output+ (input[0] + 0), result);
            return result;
        }
    }
}
