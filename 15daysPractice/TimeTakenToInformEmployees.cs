using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Versioning;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    /// <summary>
    /// https://replit.com/@indirasravanthi/Time-taken-to-inform-employees-DFS-solution-2#index.js
    /// </summary>
    public class TimeTakenToInformEmployees
    {
        public void timeTakenToInform()
        {
            int[] managers = new int[8] { 2, 2, 4, 6, -1, 4, 4, 5 };
            int[] informTimes = new int[8] { 0, 0, 4, 0, 7, 3, 6, 0 };
            int headId = 4;

            List<List<int>> adjList = new List<List<int>>();

            for(int i =0; i< managers.Length; i++)
            {
                adjList.Add(new List<int>());
            }
            List<int> empList = null;
            for(int  i =0; i< managers.Length; i++)
            {
                int manager = managers[i];
                if (manager == -1)
                    continue;
                
                empList = adjList[manager];
                empList.Add(i);
                adjList[manager] = empList;
            }

            Console.WriteLine("max time taken to inform the employees = {0}", dfs(headId, adjList, informTimes));
        }

        int dfs(int curId, List<List<int>> adjList, int[] informTimes)
        {
            List<int> subList = adjList[curId];
            if (subList == null || subList.Count == 0)
            {
                return 0;
            }

            int max = 0;
            for(int i = 0; i< subList.Count; i++)
            {
                max = Math.Max(max, dfs(subList[i], adjList, informTimes));
            }

            return max + informTimes[curId];
        }
    }
}
