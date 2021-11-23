using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.MicrosoftIQ
{
    public class ValidParanthesis
    {       
            public bool IsValid(string s)
            {
                Dictionary<char, char> dic = new Dictionary<char, char>();
                dic.Add('}', '{');
                dic.Add(')', '(');
                dic.Add(']', '[');

                Stack<char> st = new Stack<char>();
                foreach (char ch in s.ToCharArray())
                {
                    if (dic.ContainsKey(ch))
                    {
                    if (st.Count > 0)
                    {
                        char value = st.Pop();
                        if (value != dic[ch])
                            return false;
                    }
                    else
                        return false;

                    }
                    else
                        st.Push(ch);
                }
                return st.Count == 0;
            }
        
    }
}
