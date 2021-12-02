using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //udemy https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/22505032#overview
    //https://replit.com/@indirasravanthi/Number-of-Islands-DFS-2#index.js
    public class NumberOfIslands
    {
        int[,] islands = new int[5, 5]
           {
                {1,0,1,1,0 },
                {0,1,1,1,0 },
                {0,0,0,0,1 },
                {1,0,0,0,0 },
                {0,1,0,0,0 }
           };

        int[][] directions = new int[4][]
        {
            new int[2]{-1,0 },
            new int[2]{0,1 },
            new int[2]{1,0 },
            new int[2]{0,-1 }
        };
        public void getNumberOfIslands()
        {
            int countOfIslands = 0;

            for(int i =0; i< 5; i++)
            {
                for(int j =0; j< 5; j++)
                {
                    if(islands[i,j] == 1)
                    {
                        countOfIslands++;
                        dfsHelper(islands, i, j, 5);
                    }
                }
            }

            Console.WriteLine("numberof Islands = {0}", countOfIslands);
        }

        public void dfsHelper(int[,] islands, int row, int col, int arrayLength)
        {
            if (row == arrayLength || col == arrayLength || row < 0 || col < 0 || islands[row,col] == 0)
                return;

            if(islands[row,col] == 1)
            {
                islands[row, col] = 0;
                for(int dir = 0; dir < directions.Length; dir++)
                {
                    int[] curDir = directions[dir];
                    int curRow = curDir[0];
                    int curCol = curDir[1];

                    dfsHelper(islands, row + curRow, col + curCol, arrayLength);
                }
            }
        }
    }
}
