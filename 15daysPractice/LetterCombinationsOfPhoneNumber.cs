using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class LetterCombinationsOfPhoneNumber
    {
        public void phonePad(string input){
            phonePadHelper("", input);
        }

        private void phonePadHelper(string processed, string unprocessed)
        {
            if(unprocessed.Length == 0)
            {
                Console.WriteLine(processed);
                return;
            }

            int digit = (int)(unprocessed[0] - '0');
            for(int i = (digit-1) *3; i< digit * 3; i++)
            {
                char ch =  (char)('a' + i);
                phonePadHelper(processed + ch, unprocessed.Substring(1));
            }
        }
    }
}
