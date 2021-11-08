using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day8
{

    public class TreeNode {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int data)
        {
            this.data = data;
        }
    }
    public class Tree
    {
        private TreeNode root;

        public TreeNode Add(int data)
        {
            TreeNode node = new TreeNode(data);
            if (root == null)
            {
                root = node;
            }
            else if (data < root.data)
            {
                while (root.left != null)
                {
                    root = root.left;
                }
                root.left = node;
            }
            else
            {
                while (root.right != null)
                {
                    root = root.right;
                }
                root.right = node;
            }
            return root;
        }

        public TreeNode AddConstantData()
        {
            root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(3);
            root.right = new TreeNode(4);
            root.right.right = new TreeNode(3);
            root.left.right = new TreeNode(6);
            root.right.left = new TreeNode(6);

            return root;
        }

        public bool isSymmetric(TreeNode root)
        {
            if (root == null)
                return true;
            return isSymmetric(root.left, root.right);
        }

        public bool isSymmetric(TreeNode left, TreeNode right)
        {
            if(left == null || right == null)
            {
                return left == right;
            }

            if(left.data != right.data)
            return false;

            return isSymmetric(left.left, right.right) && isSymmetric(left.right, right.left);
        }

        public List<int> BFS(TreeNode node)
        {
            List<int> result = new List<int>();
            if (node == null)
                return null;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while(queue.Count > 0)
            {
                TreeNode treeNode = queue.Dequeue();
                result.Add(treeNode.data);
                if(treeNode.left != null)
                queue.Enqueue(treeNode.left);
                if(treeNode.right!=null)
                queue.Enqueue(treeNode.right);
            }

            return result;
        }

        public List<int> DFS(TreeNode node)
        {
            List<int> result = new List<int>();
            if (node == null)
                return null;
            return DFSRecursive(node,result);           
        }

        public List<int> DFSRecursive(TreeNode node,List<int> result)
        {
            if (node == null)
                return null;
            result.Add(node.data);
            DFSRecursive(node.left, result);
            DFSRecursive(node.right, result);
            return result;
        }

        public TreeNode AddDataForTraversal()
        {
            root = new TreeNode(5);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(1);
            root.right = new TreeNode(8);
            root.right.right = new TreeNode(9);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(7);

            return root;
        }

        public bool isValidBST(TreeNode root,TreeNode max, TreeNode min) 
        {
            if (root == null)
                return true;
            if (max != null && max.data < root.data || min != null && min.data > root.data)
                return false;
            return isValidBST(root.left, root, min) && isValidBST(root.right, max, root);           
        }

        public int calcDepthRecursively(TreeNode node)
        {
            if (node == null)
                return -1;

            int lh = calcDepthRecursively(node.left);
            int rh = calcDepthRecursively(node.right);

            return Math.Max(lh, rh) + 1;

           
        }

        public int depthOfTree(TreeNode root)
        {
            int depth = 0;

            if (root == null) return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            queue.Enqueue(null);           

            while(queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node == null)
                    depth++;

                if (node != null)
                {
                    if(node.left != null) queue.Enqueue(node.left);
                    if(node.right != null) queue.Enqueue(node.right);

                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }
                }

               
            }
            return depth;
        }

        /// <summary>
        /// LCA of Binary Tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public TreeNode LCA(TreeNode node, TreeNode node1, TreeNode node2)
        {
            if (node == null)
                return null;
            if (node.data == node1.data || node.data == node2.data)
                return node;
            TreeNode leftNode = LCA(node.left, node1, node2);
            TreeNode rightNode = LCA(node.right, node1, node2);

            if (leftNode != null && rightNode != null)
                return node;
            if (leftNode != null)
                return leftNode;
            if (rightNode != null)
                return rightNode;

            return node;

        }

        public TreeNode LCABST(TreeNode node, int node1, int node2)
        {
            if (node == null)
                return null;

            if(node1 < node.data && node2 < node.data)
            {
                return LCABST(node.left, node1, node2);
            }

            if (node2 > node.data && node1 > node.data)
                return LCABST(node.right, node1, node2);

            return node;
        }
    }

   
}
