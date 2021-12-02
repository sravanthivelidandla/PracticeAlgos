using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    //https://www.udemy.com/course/cpp-data-structures-algorithms-levelup-prateek-narang/learn/lecture/25418974#overview
    public class SudokuSolver
    {
        public void SolveSudokuProblem()
        {
            int[,] matrix = new int[9, 9] {
            { 0,7,5,0,0,4,0,8,0},
            { 0,2,0,0,7,0,0,1,6},
            { 1,9,0,0,0,0,0,0,7},
            { 0,0,0,0,0,0,8,7,0},
            { 5,0,0,2,0,0,0,0,9},
            { 0,0,4,0,1,6,3,0,0},
            { 0,0,1,9,0,5,0,0,0},
            { 8,6,0,0,3,0,5,0,0},
            { 3,0,0,0,6,0,0,4,2}
            };           
            
            SolveSudoku(matrix, 0, 0, 9);
        }

        void print(int[,] matrix)
        {
            for(int i =0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            Console.WriteLine();
            }
        }

        private bool SolveSudoku(int[,] matrix, int i , int j, int n)
        {
            //base case
            if(i == 9)
            {
                //print the sudoku matrix.
                print(matrix);
                return true;
            }

            //rec case
            if (j == 9)
                return SolveSudoku(matrix, i + 1, 0, n);

            if(matrix[i,j] != 0)
            {
                return SolveSudoku(matrix, i, j + 1, n);
            }

            for(int no = 1; no <=n; no++)
            {
                if (isSafe(matrix, i, j, no, n))
                {
                    matrix[i, j] = no;
                    bool solveSubproblem = SolveSudoku(matrix, i, j + 1, n);
                    if (solveSubproblem)
                        return true;
                }
            }

            matrix[i, j] = 0;
            return false;
        }

        bool isSafe(int[,] matrix, int i , int j, int no, int n)
        {

            //this number should not be there in that row and column
            for(int k =0; k < n; k++)
            {
                if (matrix[k, j] == no || matrix[i, k] == no)
                    return false;
            }

            //The number should not be present in the subgrid.
            // for that we need to identify the coordinates of the subgrid.
            int numberOfGrids = (int)Math.Sqrt(n);
            int sx = (i / numberOfGrids) * numberOfGrids;
            int sy = (j / numberOfGrids) * numberOfGrids;

            for (int x = sx; x < sx + 3; x++)
                for (int y = sy; y < sy + 3; y++)
                    if (matrix[sx, sy] == no)
                        return false;


            return true;
        }
    }
}
