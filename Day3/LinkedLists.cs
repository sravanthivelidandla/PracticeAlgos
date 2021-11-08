using PracticeAlgos.Day2;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day3
{
    public partial class LinkedLists
    {
        public bool checkIfListIsPalindrome(Node head) {
            if (head == null) return false;
            if (head.next == null) return true;

            int counter = 0;
            while(head!= null)
            {
                counter++;
                head = head.next;
            }

            Stack<Node> st = new System.Collections.Generic.Stack<Node>();
            Node slow = head; Node fast = head;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
                st.Push(slow);
            }

            if(counter%2 == 1)
            {
                slow = slow.next;
            }
            
            while(slow!=null && st.Count > 0)
            {
                if(slow == st.Pop())
                {
                    return true;
                }
                return false;
            }

            return (st.Count == 0);
        }
    }
}
