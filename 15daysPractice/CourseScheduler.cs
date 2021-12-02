using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    /// <summary>
    /// We solve this problem using Topological Sort.
    /// https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/22505054#overview
    /// </summary>
    public class CourseScheduler
    {
        public void canFinishCourses()
        {
            const int NumOfCourses = 6;
            int[][] preReqs = new int[7][]
            {
                new int[2]{1,0 },
                new int[2] {2,1},
                new int[2] {2, 5},
                new int[2] {0,3 },
                new int[2] {4,3},
                new int[2] {3,5},
                new int[2]{4,5}
            };

            //failedOutput 
            //const int NumOfCourses = 2;
            //int[][] preReqs = new int[2][]
            //{
            //    new int[2]{1,0 },
            //    new int[2] {0,1}               
            //};

            int[] inDegree = new int[NumOfCourses];
            for(int i =0; i< NumOfCourses; i++)
            {
                inDegree[i] = 0;
            }
            List<List<int>> adjList = new List<List<int>>();
            for(int i = 0; i< NumOfCourses; i++) { 
                adjList.Add(new List<int>());
            }

            for(int i = 0; i < preReqs.Length; i++)
            {
                int[] pair = preReqs[i];
                inDegree[pair[0]]++;
                adjList[pair[1]].Add(pair[0]);
            }

            Stack<int> stack = new Stack<int>();
            //Loop through and identify what are the ones with indegree as 0.
            for(int i =0; i< NumOfCourses; i++)
            {
                if(inDegree[i] == 0)
                {
                    stack.Push(i);
                }
            }

            int count = 0;
            List<int> orderOfCourses = new List<int>();
            //loop through the adjacency list for each item in the Stack
            while(stack.Count > 0)
            {
                count++;
                int curr = stack.Pop();
                orderOfCourses.Add(curr);

                List<int> adjacentItems = adjList[curr];
                for(int i =0; i< adjacentItems.Count; i++)
                {
                    inDegree[adjacentItems[i]]--;
                    if(inDegree[adjacentItems[i]] == 0)
                        stack.Push(adjacentItems[i]);
                }
            }

           Console.WriteLine("Can the courses be finished = {0}", count == NumOfCourses);
            for(int i =0; i< orderOfCourses.Count; i++)
            {
                Console.Write(orderOfCourses[i] + "-->");
            }
        }
    }
}
