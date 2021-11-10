using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Tries
{
    public class TrieNode
    {
        const int ALPHABET_SIZE = 26;
        public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
        public bool isEndWord;

        public TrieNode()
        {
            this.isEndWord = false;
            for(int i = 0; i < ALPHABET_SIZE; i++) {
                children[i] = null;
            }
        }

        public void markAsLeaf()
        {
            this.isEndWord = true;
        }

        public void unMarkAsLeaf()
        {
            this.isEndWord = false;
        }

    }

    public class Trie
    {
        public TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }
        //function to insert the key
        public void insertNode(string key)
        {
            if (string.IsNullOrEmpty(key))
                return;

            key = key.ToLower();

            TrieNode currentNode = root;

            for(int i =0; i< key.Length; i++)
            {
                int index = this.getIndex(key[i]);

                if(currentNode.children[index] == null)
                {
                    currentNode.children[index] = new TrieNode();
                    Console.WriteLine(" char '{0}' is inserted", key[i]);
                }
                currentNode = currentNode.children[index];
            }
            currentNode.markAsLeaf();
            Console.WriteLine("key '{0}' is inserted into the Trie", key);
        }

        //function to delete the key
        public bool deleteNode(string key)
        {
            if (key == String.Empty)
                return false;
            TrieNode currentNode = root;
            if (currentNode == null)
                return false;

            key = key.ToLower();
            return deleteHelper(currentNode, key, key.Length, 0);           
        }

        private bool hasChildren(TrieNode node)
        {
            for(int i =0; i< 26; i++)
            {
                if (node.children[i] != null)
                    return false;
            }
            return true;
        }

        private bool deleteHelper(TrieNode currentNode, string key, int length, int level)
        {
            bool isDeletedSelf = true;

            if(level == length)
            {
                if (hasChildren(currentNode))
                {
                    isDeletedSelf = false;
                    currentNode.unMarkAsLeaf();
                }
                else
                {
                    currentNode = null;
                    isDeletedSelf = true;
                }
            }
            else
            {
                TrieNode childNode = currentNode.children[getIndex(key[level])];
                bool isChildDeleted = deleteHelper(childNode, key, length, level + 1);
                if (isChildDeleted)
                {
                    currentNode.children[getIndex(key[level])] = null;

                    if (currentNode.isEndWord)
                        isDeletedSelf = false;

                    if (hasChildren(currentNode))
                    {
                        isDeletedSelf = true;
                        currentNode = null;
                    }
                    else
                    {
                        isDeletedSelf = false;
                    }
                }
                else
                {
                    isDeletedSelf = false;
                }
            }
            return isDeletedSelf;
        }

        //function to search the key
        public bool searchNode(string key)
        {
            if (string.IsNullOrEmpty(key))
                return false;

            TrieNode currentNode = root;
            if (root == null)
                return false;

            key = key.ToLower();

            for(int i =0; i< key.Length; i++)
            {
                int index = this.getIndex(key[i]);

                if (currentNode.children[index] == null)
                    return false;
                currentNode = currentNode.children[index];
            }

            if (currentNode != null && currentNode.isEndWord)
                return true;

            return false;
        }
        //function to get the index of a key;
        public int getIndex(char t)
        {
            return t - 'a';
        }
    }
}
