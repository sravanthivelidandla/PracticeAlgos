using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day2
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data, Node next =  null)
        {
            this.data = data;
            this.next = next;
        }
    }
    public partial class LinkedLists
    {
        Node _head;

        public Node add(int data)
        {
            if(_head == null)
            {
                _head = new Node(data, null);
            }
            else
            {
                Node current = _head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data, null);
            }
            return _head;
        }



        public Node CircularAdd(int data)
        {
            if (_head == null)
            {
                _head = new Node(data, null);
            }
            else
            {
                Node current = _head;
                while (current.next != null)
                {
                    current = current.next;
                }
                if (data == 6)
                    current.next = new Node(data, _head.next);
                else
                    current.next = new Node(data, null);
            }
            return _head;
        }
        public Node reverseLinkedListIterative(Node head)
        {
            if (head == null) return null;
            if (head.next == null) return null;

            Node prev = null;
            

            while(head != null)
            {
                Node current = new Node(head.data);
                current.next = prev;
                prev = current;
                head = head.next;
            }
            _head = prev;
            return prev;
        }


        public Node reverseLinkedListRecursive(Node head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            return reverseLinkedListRecursively(head, null);
        }

        public Node reverseLinkedListRecursively(Node head, Node prev)
        {
            if (head == null)
            {
                _head = prev;
                return prev;
            }
        

            Node current = new Node(head.data);
            current.next = prev;
            prev = current;

            return reverseLinkedListRecursively(head.next, prev);
        }

        public Node reverseLinkedListWithStack(Node head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            Stack<Node> st = new Stack<Node>();
            while(head != null)
            {
                st.Push(head);
                head = head.next;
            }

            Node prev = null;
            while (st.Count > 0)
            {
                Node newNode = st.Pop();
                newNode.next = prev;
                prev = newNode;
            }
            _head = prev;
            return prev;
        }

        public void displayLinkedList()
        {
            while(_head != null)
            {
                Console.Write(_head.data + "-->");
                _head = _head.next;
            }
            Console.Write("null");
        }
        
        //MergeTwo sorted lists.
        public Node MergeLinkedLists(Node l1,Node l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            Node prev = null, head = null;
            while(l1!= null && l2 != null)
            {
                Node current = null;
                if(l1.data < l2.data)
                {
                    current = new Node(l1.data);
                    l1 = l1.next;
                }
                else
                {
                    current = new Node(l2.data);
                    l2 = l2.next;
                }

                if(prev != null)
                {
                    prev.next = current;
                }
                else
                {
                    head = current;
                }
                prev = current;
            }

            while(l1!= null)
            {
                Node current = new Node(l1.data);
                prev.next = current;
                prev = current;
                l1 = l1.next;
            }

            while(l2 != null)
            {
                Node current = new Node(l2.data);
                prev.next = current;
                prev = current;
                l2 = l2.next;
            }
            _head = head;
            return head;
        }

        //detect cycle
        public bool hasCycle(Node head)
        {
            if (head == null) return false;
            if (head.next == null) return false;

            Node slow =  head;
            Node fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }

        public int length(Node head)
        {
            if (head == null) return 0;
            if (head.next == null) return 1;

            int counter = 0;
            Hashtable ht = new Hashtable();
            while(head != null)
            {               
                if (ht.ContainsKey(head.data))
                {
                    break;
                }
                else
                {
                    ht[head.data] = true;
                }
                counter++;
                head = head.next;
            }
            return counter;
        }

        public bool checkIfListIsPalindrome(Node head)
        {
            if (head == null) return false;
            if (head.next == null) return true;

            int counter = 0;
            Node slow = head; Node fast = head;

            while (head != null)
            {
                counter++;
                head = head.next;
            }

            Stack<int> st = new System.Collections.Generic.Stack<int>();
           
            while (fast != null && fast.next != null)
            {
                st.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;               
            }

            if (counter % 2 == 1)
            {
                slow = slow.next;
            }

            while (slow != null && st.Count > 0)
            {
                if (slow.data != st.Pop())
                {
                    return false;
                }
                slow = slow.next;
            }

            return (st.Count == 0);
        }

        public Node removeDuplicates(Node head)
        {
            if (head == null) return null;

            if (head.next == null) return head;

            Node prev = head;
            Node cur = head.next;

            while (cur != null)
            {
                if(prev.data == cur.data)
                {
                    prev.next = cur.next ;
                }
                else
                {
                    prev = cur;
                }
                cur = cur.next;
            }
            _head = head;
            return head;
        }

        //remove duplicaets from unsorted linkedlist
        public Node removeDuplicatesFromUnsortedList(Node head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            HashSet<int> visited = new HashSet<int>();

            Node prev = head;  Node current = head.next;
            visited.Add(prev.data);
            while (current != null)
            {
                if (!visited.Contains(current.data))
                {
                    visited.Add(current.data);
                    prev = current;
                }
                else
                {
                    prev.next = current.next;
                }                
                current = current.next;
            }
            _head = head;
            return head;
        }

        public Node removeDuplicatesUnSortedListWithNoAdditionalSpace(Node head)
        {
            if (head == null) return null;
            if (head.next == null) return head;

            Node current = head;
            while(current != null)
            {
                Node runner = current;
                if(runner.next != null)
                {
                    if (runner.next.data == current.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }
                current = current.next;
            }
            _head = head;
            return head;
        }
    }
}
