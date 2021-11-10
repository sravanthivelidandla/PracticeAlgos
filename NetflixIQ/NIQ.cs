using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.NetflixIQ
{
    /// <summary>
    /// REfer to Educative.io, 
    /// https://www.educative.io/courses/decode-the-coding-interview-csharp/gk4RBVkZZDY
    /// </summary>
    public class NIQ
    {
        /// <summary>
        /// Valid browser session
        /// </summary>
        /// <param name="push"></param>
        /// <param name="pop"></param>
        /// <returns></returns>
        public bool isValidOperations(int[] push, int[] pop)
        {
            if (push.Length != pop.Length) return false;

            Stack<int> stack = new Stack<int>();

            int j = 0;
            for(int i =0; i< push.Length; i++)
            {
                stack.Push(push[i]);

               while(stack.Count != 0 && stack.Peek() == pop[j])
                {
                    stack.Pop();
                    j++;
                }
            }

            if (stack.Count == 0)
                return true;
            else return false;
        }
    }
}
