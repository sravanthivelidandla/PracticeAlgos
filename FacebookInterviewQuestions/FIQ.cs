using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.FacebookInterviewQuestions
{
    /// <summary>
    /// Refer to Educative.io for all the questions.
    /// https://www.educative.io/courses/decode-the-coding-interview-csharp/m7GQxGmLvpR
    /// </summary>
    public class FIQ
    {
        public List<List<string>> groupSimilarMessages(List<string> messages)
        {
            //generate key for each message
            //Take a dictionary and add the messages which yeilds the same key to this.
            IDictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach(string message in messages)
            {
                string key = generateKey(message);
                List<string> groupedMessages = new List<string>();
                if (result.ContainsKey(key))
                {
                    groupedMessages = result[key];
                    
                }
                groupedMessages.Add(message);
                result[key] = groupedMessages;
            }
            return new List<List<string>>(result.Values);
        }

        private string generateKey(string message)
        {
            Char[] chars = message.ToCharArray();
            string key = "";

            for(int i =1; i< chars.Length; i++)
            {
                int diff = chars[i] - chars[i - 1];
                key += diff < 0 ? diff + 26 : diff;

            }
            return key;
        }

        public int friendCircles(bool[][] friends, int n)
        {
            bool[] visited = new bool[n];
            int numCircles = 0;
            for(int i = 0; i< n; i++)
            {
                visited[i] = false;
            }

            for(int i =0; i < n; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    DFS(friends, visited, n, i);
                    numCircles++;
                }
            }
            return numCircles;
        }

        private void DFS(bool[][] friends, bool[] visited, int n, int v)
        {
            for(int i = 0; i < n; i++)
            {
                if(friends[i][v] == true && !visited[i] && i!= v)
                {
                    visited[i] = true;
                    DFS(friends, visited, n, i);
                }
            }
        }

        public int FindStory(int[] array, int key)
        {
            return SearchStory(array, 0, array.Length - 1, key);
        }

        private int SearchStory(int[] array, int start, int end, int key)
        {
            if (start > end) return -1;

            int mid = start +  (end - start) / 2;

            if (array[mid] == key) return mid;

            else if (array[start] <= array[mid] && key >= array[start] && key <= array[mid])
                return SearchStory(array, start, mid - 1, key);
            else if (array[mid] <= array[end] && key >= array[mid] && key <= array[end])
                return SearchStory(array, mid + 1, end, key);
            else if (array[end] <= array[mid])
                return SearchStory(array, mid + 1, end, key);
            else if (array[start] >= array[mid])
                return SearchStory(array, start, mid - 1, key);

            return -1;
        }

        public bool flagWords(string s, string w)
        {
            if(s == null || w == null )
            {
                return false;
            }

            int i = 0, j = 0;
            while(i < s.Length && j < w.Length)
            {
                if(s[i] == w[j])
                {
                    int len1 = repeatedWords(s, i);
                    int len2 = repeatedWords(w, j);

                    if ((len1 >= 3 && len1 < len2) || len1 < 3 && len1 != len2)
                        return false;

                    i += len1;
                    j += len2;
                }
                else
                return false;
            }

            return i == s.Length && j == w.Length;
        }

        private int repeatedWords(string s, int i)
        {
            int temp = i;
            
            while(temp < s.Length && s[temp] == s[i])
            {
                temp++;
            } 
            return temp - i;
            
        }


        public int expressiveWords(string S, string[] words)
        {
            int count = 0;
            foreach (string w in words)
            {
                int i = 0;
                int j = 0;
                bool isexpressive = false;

                while (i < S.Length && j < w.Length)
                {
                    if (S[i] == w[j])
                    {
                        int len1 = calcLength(S, i);
                        int len2 = calcLength(w, j);

                        if ((len1 >= 3 && len1 < len2) || (len1 < 3 && len1 != len2))
                        {
                            isexpressive = false;
                            break;
                        }
                        i += len1;
                        j += len2;
                    }
                    else
                    {
                        isexpressive = false;
                        break;
                    }
                    isexpressive = true;
                }
                if (isexpressive)
                {
                    count++;
                    Console.WriteLine(w);
                }
                
            }
            return count;
        }
        static int calcLength(string s, int i)
        {
            int temp = i;
            while (temp < s.Length && s[temp] == s[i])
            {
                temp++;
            }
            return temp - i;
        }


        public  int SearchRotated(int[] arr, int key)
        {
            // write your code here
            if (arr == null || arr.Length == 0) return -1;
            return SearchR(arr, 0, arr.Length, key);

        }

        private int SearchR(int[] a, int start, int end, int key)
        {

            if (start > end) return -1;
            int mid = start + (end - start) / 2;

            if (a[mid] == key) return mid;

            else if (a[start] <= a[mid] && key >= a[start] && key <= a[mid])
                return SearchR(a, start, mid - 1, key);

            else if (a[end] >= a[mid] && key <= a[end] && key >= a[mid])
                return SearchR(a, mid + 1, end, key);

            else if (a[end] <= a[mid])
                return SearchR(a, mid + 1, end, key);

            else if (a[start] >= a[mid])
                return SearchR(a, start, mid - 1, key);

            return -1;
        }


        #region numOfIslands will not work for mxn matrix.
        //public int numIslands(String[][] islands)
        //{
        //    int count = 0;
        //    if (islands == null) return 0;

        //    bool[] visited = new bool[] { false, false, false, false, false };

        //    int rowCount = islands.Length - 1;
        //    int colCount = islands[0].Length - 1;

        //    for (int i = 0; i < colCount; i++)
        //    {
        //        if (!visited[i])
        //        {
        //            visited[i] = true;
        //            DFS1(islands, visited, rowCount, i);
        //            count++;
        //        }
        //    }
        //    return count;
        //}

        //void DFS1(string[][] islands, bool[] visited, int rowCount, int v)
        //{
        //    for (int i = 0; i < rowCount; i++)
        //    {
        //        if (!visited[i] && i != v && islands[i][v] == "1")
        //        {
        //            visited[i] = true;
        //            DFS1(islands, visited, rowCount, i);
        //        }
        //    }
        //}
        #endregion

        int[][] directions = new int[][]
        {
            new int[]{-1,0 },
            new int[]{0,1},
            new int[]{1,0} ,
            new int[]{0,-1} };
        public int numOfIslands(string[][] islands)
        {
            if (islands == null || islands.Length == 0) return 0;

            int countOfIslands = 0;

            for(int row =0; row< islands.Length; row++)
            {
                for(int col =0; col<islands[0].Length; col++)
                {
                    if(islands[row][col] == "1")
                    {
                        countOfIslands++;
                        DFSIslands(islands, row, col);
                    }
                }
            }
            return countOfIslands;
        }

        private void DFSIslands(string[][] islands,int curRow, int curCol)
        {
            if (curRow < 0 || curRow >= islands.Length || curCol < 0 || curCol >= islands[0].Length)
                return;

            if(islands[curRow][curCol] == "1")
            {
                islands[curRow][curCol] = "0";

                for(int i =0; i< directions.Length; i++)
                {
                    int[] direction = directions[i];
                    int row = direction[0];
                    int col = direction[1];

                    DFSIslands(islands, curRow + row, curCol + col);
                }
            }
        }

    }
}
