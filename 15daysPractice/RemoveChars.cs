using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class RemoveChars
    {
        public string replaceChars(string input)
        {
            return replaceCharsHelper(input, "",0);
        }

        private string replaceCharsHelper(string input, string output,int index)
        {
            if (index == input.Length)
                return output;

            if (input[index] != 'a')
                output += input[index];

            return replaceCharsHelper(input, output, index + 1);
        }

        public string skipAppNotApple(string input)
        {
            return helper(input);
        }

        string helper(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            if( input.StartsWith("app") && !input.StartsWith("apple"))
            {
                return input.Substring(0,3);
            }
            return input[0] + input.Substring(1);
        }
    }
}
