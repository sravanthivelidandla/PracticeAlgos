using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day4
{
    public class Strings
    {
        private const char emptyLiteral = '\0';

        public string replaceAllOccurancesOfString2(string str1, string str2) { 

            if(str1.Length > 0 && str2.Length > 0)
            {
                foreach(char ch in str2.ToCharArray())
                {
                   str1 = str1.Replace(ch, emptyLiteral);
                }
            }
            return str1;
        }

        public string replaceCharsOfString2(string str1, string mask)
        {
            HashSet<char> chars = new HashSet<char>();
            foreach(char ch in mask.ToCharArray())
            {
                chars.Add(ch);
            }

            foreach(char ch in str1.ToCharArray())
            {
                if (chars.Contains(ch))
                {
                    str1 = str1.Replace(ch, '\0');
                }
            }

            return str1;
        }

        public bool checkIfSubstring(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            if(str1.Length > 0 && str2.Length > 0)
            {
                string str3 = str1 + str1;
                if (str3.Contains(str2))
                    return true;
            }
            return false;
        }

        public string returnColumnName(int input)
        {
           
            string result = "";
           while(input > 0)
            {
                int reminder = input % 26;
                if (reminder == 0)
                {
                    result += 'Z';
                    input = (input / 26) - 1;
                }
                else
                {
                    result += (char)((reminder - 1) + 'A');
                    input = input / 26;
                }
            }
            char[] reverseArray = result.ToCharArray();
            Array.Reverse(reverseArray);
            return new String(reverseArray);
        }

        public int returnColumnNumber(string input)
        {
            int result = 0;
            for(int i = 0; i < input.Length; i++)
            {
                result *= 26;
                result += input[i] - 'A' + 1;
            }
            return result;
        }

        public bool paranthesisMatch(string input)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            Stack<char> st = new Stack<char>();
            dic.Add('{', '}');
            dic.Add('(', ')');
            dic.Add('[', ']');

            foreach (char c in input)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    st.Push(dic[c]);
                }
                if (c == '}' || c == ']' || c == ')')
                {
                    char paranthesis = st.Pop();
                    if (paranthesis != c)
                        return false;
                }
            }

            return st.Count == 0;
        }

    }
}
