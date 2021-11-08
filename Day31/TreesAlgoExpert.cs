using System;
using System.Collections.Generic;
using System.Text;
using PracticeAlgos.Day8;

namespace PracticeAlgos.Day31
{
    public class TreesAlgoExpert
    {
        TreeNode minDiffNode = null;
        int curDiff = 0;
        int minDiff = int.MaxValue;

        public TreeNode findClosestNode(TreeNode root, int data)
        {
            if (root == null) return null;            
            return calcMinDiffNode(root, data);
        }

        private TreeNode calcMinDiffNode(TreeNode node,int data)
        {
            if (node == null) return minDiffNode;
            TreeNode currentNode = node;           

            while (currentNode != null)
            {
                calcClosestDiff(currentNode, data);

                if(minDiff == 0)
                {
                    return minDiffNode;
                }

                if (data <= currentNode.data)
                    currentNode = currentNode.left;
                else
                    currentNode = currentNode.right;
            }
            return minDiffNode;

        }

        private void calcClosestDiff(TreeNode node, int data)
        {
            curDiff = Math.Abs(node.data - data);
            if(minDiff > curDiff)
            {
                minDiff = curDiff;
                minDiffNode = node;
            }
        }

        public int findClosestNodeRecursive(TreeNode root, int target)
        {
            if (root == null) return -1;
            return findClosestNodeInBST(root, target, root.data);
        }

        private int findClosestNodeInBST(TreeNode root, int target, int closest)
        {
            if(Math.Abs(target-closest) > Math.Abs(root.data - target)) 
            {
                closest = root.data;
            }

            if(target < root.data && root.left != null)
            {
                return findClosestNodeInBST(root.left, target, closest);
            }
            else if(target > root.data && root.right != null){
                return findClosestNodeInBST(root.right, target, closest);
            }
            else
            {
                return closest;
            }
        }
        
        public void inorderTraversal(TreeNode root)
        {
            if (root == null) return;

            inorderTraversal(root.left);
            Console.WriteLine(root.data);
            inorderTraversal(root.right);
        }

        public void preOrderTraversal(TreeNode node)
        {
            if(node == null) return;
            Console.WriteLine(node.data);
            preOrderTraversal(node.left);
            preOrderTraversal(node.right);
        }

        public void postOrderTraversal(TreeNode node)
        {
            if (node == null) return;
            postOrderTraversal(node.left);
            postOrderTraversal(node.right);
            Console.WriteLine(node.data);
        }

        public int findKthLargestElement(TreeNode node, int k)
        {
            List<int> items = new List<int>();
            findKthLargestElementRecursive(node, k, items);
            return k > items.Count? -1 : items[k - 1];
        }

        private void findKthLargestElementRecursive(TreeNode node, int k, List<int> items)
        {
            if (node == null) return;
            if (items.Count == k)
                return;
            findKthLargestElementRecursive(node.right,k,items);
            if (node != null && items.Count < k)
            {
                items.Add(node.data);
            }
            findKthLargestElementRecursive(node.left, k, items);           
        }
    }
}
