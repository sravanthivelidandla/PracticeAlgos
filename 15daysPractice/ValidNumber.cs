using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public  class ValidNumber
    {
        //https://leetcode.com/problems/valid-number/solution/
        /// <summary>
        /// numbers which are valid 21,+21, -21, 21e+7,21.34
        /// numbers which are not valid 21.21.21, +21e++7,-21E7
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool isValidNumber(string number)
        {
            bool seenDigit = false;
            bool seenDot = false;
            bool seenExponent = false;

            for(int i = 0; i< number.Length; i++)
            {
                if(char.IsDigit(number[i])) {
                    seenDigit = true;
                }
                else if (number[i] == '+' || number[i] == '-')
                {
                    if(i >0 && !(number[i-1] == 'e' || number[i-1] == 'E'))
                    {
                        return false;
                    }
                }
                else if(number[i] == 'E' || number[i] == 'e')
                {
                    if (seenExponent || !seenDigit)
                        return false;

                    seenExponent = true;
                    seenDigit = false;
                }
                else if(number[i] == '.')
                {
                    if (seenDot || seenExponent)
                        return false;
                    seenDot = true;
                }
                else
                {
                    return false;
                }
            }
            return seenDigit;
        }
    }
}
