using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos
{
    public class LRCSubstring
    {
        //input : AABAA, k=1 
        //output : 5
        public int maxSubStringLength(string args, int k)
        {
            int startPointer = 0;
            int endPointer = 0;
            int flipCount = 0;
            int maxLength = 0;

            foreach(Char ch in args.ToCharArray())
            {
                if(ch == 'A')
                {
                    endPointer++;
                }
                else
                {
                    if(ch == 'B' && flipCount < k)
                    {
                        endPointer++;
                        flipCount++;
                    }
                    else
                    {
                        while(flipCount == k)
                        {
                            if(ch == 'B')
                            {
                                flipCount--;
                            }
                            startPointer++;
                        }
                    }
                }

                maxLength = Math.Max(maxLength, endPointer - startPointer);
            }

            return maxLength;
        }
    }
}
