using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/22417074#overview
    //https://replit.com/@indirasravanthi/Walls-and-Gates-Solution-1#index.js
    public class WallsAndGates
    {
        const int INF = int.MaxValue;
        int[,] matrix = new int[4, 4]
          {
                {-1,0,INF,INF},
                {INF,INF,INF,0 },
                {INF,0,INF,INF},
                {-1,INF,INF,INF }
          };

        int[][] directions = new int[4][]
        {
            new int[2]{-1,0 },
            new int[2]{0,1 },
            new int[2]{1,0 },
            new int[2]{0,-1 }
        };

        public void fillDistanceMatrix()
        {
            for(int i =0; i< 4; i++)
            {
                for(int j =0; j < 4; j++)
                    if(matrix[i,j] == 0)
                    {
                        dfs(matrix, i, j, 0);
                    }
            }

            print(matrix);
        }

        private void print(int[,] matrix)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                   Console.Write(matrix[i,j] + " ");
                Console.WriteLine();
            }
        }

        void dfs(int[,] matrix, int row, int col, int count)
        {
            //base case
            if(row == 4 || col == 4 || row < 0 || col < 0 || matrix[row, col] < count)
            {
                return;
            }

            matrix[row, col] = count;
            for(int i =0; i< directions.Length; i++)
            {
                int[] curDir = directions[i];
                dfs(matrix, row + curDir[0], col + curDir[1], count + 1);
            }
        }
    }
}
