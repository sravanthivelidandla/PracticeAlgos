using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PracticeAlgos._15daysPractice
{

    /// <summary>
    /// https://www.udemy.com/course/master-the-coding-interview-big-tech-faang-interviews/learn/lecture/22505032#overview
    /// https://replit.com/@indirasravanthi/Rotting-Oranges-Solution-2#index.js
    /// </summary>
    public class RottenOranges
    {
        int m = 3, n = 3;
        int[,] rottenOranges = new int[3, 3]
        {
            {2,1,1 },
            {1,1,0 },
            {0,1,1 }
        };

      
        int[][] directions = new int[4][]
       {
            new int[2]{-1,0 },
            new int[2]{0,1 },
            new int[2]{1,0 },
            new int[2]{0,-1 }
       };
        const int ROTTEN = 2;
        const int FRESH = 1;
        const int EMPTY = 0;

        public class grid
        {
            public int row;
            public int col;
            public grid(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }

        public void calcTimeTakenToRottenOranges()
        {
            Console.WriteLine("time taken to rotten all oranges = {0}", getTimeTakenToRottenAllOranges());
        }

        public int getTimeTakenToRottenAllOranges()
        {
            int freshOranges = 0;
            int minutes = 0;
            int curQueueLength = 0;

            Queue<grid> queue = new Queue<grid>();


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rottenOranges[i, j] == ROTTEN)
                        queue.Enqueue(new grid(i, j));

                    if (rottenOranges[i, j] == FRESH)
                        freshOranges++;
                }
            }


            curQueueLength = queue.Count;
            while (queue.Count > 0)
            {
                if(curQueueLength == 0)
                {
                    minutes++;
                    curQueueLength = queue.Count;
                }

                grid gridObj = queue.Dequeue();
                curQueueLength--;

                for (int dir = 0; dir < directions.Length; dir++)
                {
                    int[] curDir = directions[dir];
                    int curRow = curDir[0] + gridObj.row;
                    int curCol = curDir[1] + gridObj.col;

                    if (curCol < 0 || curRow < 0 || curCol == m || curRow == m)
                        continue;

                    if(rottenOranges[curRow,curCol] == FRESH)
                    {
                        freshOranges--;
                        rottenOranges[curRow, curCol] = ROTTEN;
                        queue.Enqueue(new grid(curRow, curCol));
                    }
                }

            }

            if (freshOranges > 0)
                return -1;

            return minutes;


        }
    }
}
