using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.NetflixIQ
{
    //Browse ratings Problem
    public class MaxStack
    {
        Stack<int> maxStack;
        Stack<int> mainStack;

        public MaxStack()
        {
            maxStack = new Stack<int>();
            mainStack = new Stack<int>();
        }

        public int pop()
        {
            maxStack.Pop();
            return mainStack.Pop();
        }

        public void push(int rating) {
            mainStack.Push(rating);

            if(maxStack.Count != 0 && maxStack.Peek() > rating)
            {
                maxStack.Push(maxStack.Peek());
            }
            else
            {
                maxStack.Push(rating);
            }

        }

        public int getMaxRating()
        {
            return maxStack.Peek();
        }
    }
}
