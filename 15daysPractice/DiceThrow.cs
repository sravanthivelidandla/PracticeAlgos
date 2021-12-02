using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class DiceThrow
    {
        public void diceThrow(int target)
        {
            diceHelper("", target,7);
        }
        void diceHelper(string p, int target,int face)
        {
            if(target == 0)
            {
                Console.WriteLine(p);
                return;
            }

            for(int i =1; i<= face && i<= target; i++)
            {
                diceHelper(p + i, target - i,face);
            }
        }
    }
}
