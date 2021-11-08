using PracticeAlgos.Day8;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day12
{
    public class TreesAdvanced
    {
        public void printLevelOrderTraversal(TreeNode node)
        {
            if (node == null)
                Console.WriteLine("Tree is Empty");
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);
            queue.Enqueue(null);

            while(queue.Count > 0)
            {
                TreeNode node1 = queue.Dequeue();
                if(node1 != null)
                {
                    Console.Write(node1.data+ "-->");
                    if (node1.left != null)
                        queue.Enqueue(node1.left);
                    if (node1.right != null)
                        queue.Enqueue(node1.right);
                }
                else
                {
                    if(queue.Count > 0)
                        queue.Enqueue(null);
                    Console.WriteLine();
                }
            }
        }

        public void printBoundaryTraversal(TreeNode root)
        {
            if (root == null) return;

            Console.Write(root.data);
            printLeftNodes(root.left);
            printLeaves(root.left);
            printLeaves(root.right);
            printRightNodes(root.right);
        }

        private void printLeftNodes(TreeNode node)
        {
            if (node == null) return;

            if(node.left != null)
            {
                Console.Write("-->" + node.data);
                printLeftNodes(node.left);
            }
            else
            {
                if(node.right != null)
                {
                    Console.Write("-->" + node.data);
                    printLeftNodes(node.right);
                }
            }
        }

        private void printLeaves(TreeNode node)
        {
            if (node == null) return;
            printLeaves(node.left);
            if (node.left == null && node.right == null)
                Console.Write("-->"+ node.data);
            printLeaves(node.right);
        }

        private void printRightNodes(TreeNode node)
        {
            if (node == null) return;
            if(node.right != null)
            {
                printRightNodes(node.right);
                Console.Write("-->"+ node.data);
            }
            else if(node.left != null)
            {
                printRightNodes(node.left);
                Console.Write("-->"+ node.data);
            }
        }

        public void printDigonalElementsOfATree(TreeNode root)
        {
            //if (root == null)
            //    Console.WriteLine("Tree is Empty");

            //Queue<TreeNode> queue = new Queue<TreeNode>();

            //queue.Enqueue(root);
            //Dictionary<int, List<TreeNode>> dic = new Dictionary<int, TreeNode>();

            //int dd = 0;
            //while(queue.Count > 0)
            //{
            //    TreeNode node = queue.Dequeue();
            //    if (!dic.ContainsKey(dd))
            //    {
            //        dic.Add(dd, new List<TreeNode>() { node });
            //    }
            //}



        }


    }
}
