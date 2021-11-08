using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos
{
    public class Conversions
    {
        readonly char[] charCodeArray = new char[26] { '2', '2', '2', '3', '3','3','4', '4', '4', '5', '5', '5', '6', '6', '6', '7', '7', '7', '7', '8', '8', '8', '9', '9', '9', '9' };
        public string alphaPhoneToNumeric(string phoneNumber)
        {         
            foreach (char c in phoneNumber.ToCharArray()) {
                
                if (char.IsLetter(c))
                {
                    int index = ((int)c - (int)'A');
                    phoneNumber = phoneNumber.Replace(c, charCodeArray[index]);
                }              
            }
            return phoneNumber;
        }

        Dictionary<char, int> romanDictionary = new Dictionary<char, int>()
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'C',100 },
            {'L',50 },
            {'D',500 },
            {'M',1000 }
        };

        private int getValue(char roman)
        {
            if (romanDictionary.ContainsKey(roman))
            {
                return romanDictionary[roman];
            }
            else
                return 0;
        }

        public int convertRomanToNumeral(string romanNumber)
        {
            int number = 0;
            if (string.IsNullOrEmpty(romanNumber)) { return 0; }
            
            int length = romanNumber.Length-1;
            int total = getValue(romanNumber[length]);
            for (int i = length-1 ; i >= 0; i--)
            {
                if(getValue(romanNumber[i]) < getValue(romanNumber[i + 1]))
                {
                    total -= getValue(romanNumber[i]);
                }
                else
                {
                    total += getValue(romanNumber[i]);
                }
            }

            return total;
        }

        string[] roman = new string[] { "M", "CM", "D", "CD", "C", "LC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public string convertToRoman(int number)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();

            while(number > 0)
            {
                if(number - values[i] >= 0)
                {
                    sb.Append(roman[i]);
                    number -= values[i];
                }
                else
                {
                    i++;
                }
            }
            return sb.ToString();
        }

    }
}
