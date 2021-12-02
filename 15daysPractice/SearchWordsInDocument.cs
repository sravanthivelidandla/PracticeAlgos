using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using PracticeAlgos.Tries;

namespace PracticeAlgos._15daysPractice
{
    //https://www.udemy.com/course/cpp-data-structures-algorithms-levelup-prateek-narang/learn/lecture/23510300#overview
    public class SearchWordsInDocument
    {
        string document = "little cute cat is jumping on the bed";
        List<string> words = new List<string>(){ "ttle", "cute cat", "cat", "jump", "quick", "big" };

        public void searchDocument() {

            Trie trie = new Trie();
           foreach(string word in words)
            {
                trie.insertNode(word);
            }

            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
            for (int i = 0; i < document.Length; i++)
            {
                searchWords(document, trie, dictionary, i);
            }

            foreach(string word in words)
            {
                if(dictionary.ContainsKey(word))
                {
                    Console.WriteLine("{0} : true",word);
                }
                else
                    Console.WriteLine("{0} : false",word);
            }
        }

        private void searchWords(string document, Trie trie, Dictionary<string, bool> dictionary, int i)
        {
            if (i == document.Length)
                return;
            TrieNode currentNode = trie.root;
           
            for(int j =i; j< document.Length; j++)
            {
                int index = trie.getIndex(document[j]);
                if (currentNode.children[index] == null)
                    return;
                
                currentNode = currentNode.children[index];
                if (currentNode.isEndWord)
                {
                    dictionary.Add(document.Substring(i, j-i + 1), true);
                }
            }
        }
    }
}
