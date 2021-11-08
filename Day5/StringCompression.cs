using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day5
{
    public class StringCompressionPractice
    {
        public string CompressString(string input)
        {
            
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder compressedString = new StringBuilder();
            Char prev = input[0];
            int counter = 0;

            foreach(char ch in input)
            {
                if(prev == ch)
                {
                    counter++;
                }
                else
                {
                    getCompressedString(compressedString, prev, counter);
                    prev = ch;
                    counter = 1;
                }
            }
            getCompressedString(compressedString,prev,counter);
            return compressedString.ToString();           
        }

        private void getCompressedString(StringBuilder compressedString, char prev, int counter)
        {
            if (counter > 1)
                compressedString.Append(counter);
            compressedString.Append(prev);
        }

        public string stringCompressionRLE(string input)
        {
            if (String.IsNullOrEmpty(input)) return input;

            StringBuilder sb = new StringBuilder();

            for(int i =0; i< input.Length; i++)
            {
                int counter = 1;
                while(i<input.Length -1 && input[i] == input[i+1])
                {
                    counter++;
                    i++;
                }
                sb.Append(counter).Append(input[i]);
            }
            return sb.ToString();
        }

        public string unCompressRLE(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            StringBuilder sb = new StringBuilder();

            for(int i =0; i< input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int counter =input[i] - '0';
                    while(counter > 0)
                    {
                        sb.Append(input[i + 1]);
                        counter--;
                    }
                    i++;
                }
                else
                sb.Append(input[i]);
            }
            return sb.ToString();
        }

        public string removeDuplicates(string input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i =0; i< input.Length - 1; i++)
            {
                if(input[i] != input[i + 1])
                {
                    sb.Append(input[i]);                    
                }                
            }
            sb.Append(input[input.Length - 1]);
            return sb.ToString();
        }

        public string removeDuplicates2(string input)
        {
            if (input.Length < 1)
                return input;
            if (input[0] == input[1])
                return removeDuplicates2(input.Substring(1));
            else
                return input[0] + removeDuplicates2(input.Substring(1));
        }
    
    }
}
