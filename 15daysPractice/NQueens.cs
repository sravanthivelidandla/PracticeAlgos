using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos._15daysPractice
{
    public class NQueens
    {
        public void solveQueens()
        {
            int[,] board = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };



            // solveNQueensRecursive(board, 0,4);
            // solveQueensCountWays(board, 0, 4);
           ;
            Console.WriteLine("Number of ways to solve = {0}", solveQueensCountWays(board, 0, 4));


        }

        void printBoard(int[,] board,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                   Console.Write(board[i, j] + " ");

                Console.WriteLine();
            }

        }

        private bool solveNQueensRecursive(int[,] board, int i, int n)
        {
            if (i == n)
            {
                printBoard(board,n);
                return true;
            }

            for(int j=0; j < n; j++)
            {
                if (isSafer(board, i,j, n) == 1)
                {
                    board[i, j] = 1;
                    bool solveSubQueens = solveNQueensRecursive(board, i + 1,  n);
                    if (solveSubQueens)
                        return true;

                    board[i, j] = 0;
                }
               
            }
            return false;
        }

        private bool isSafe(int[,] board, int i, int j, int n)
        {
           //ther should not be any queen in the column 
           for(int m =0; m < i; m++)
            {
                if (board[m, j] == 1)
                    return false;
            }

            //check for left diagonal
            int k = i, l = j;
            while(k >=0 && l>= 0)
            {
                if(board[k, l] == 1)
                    return false;

                k--;l--;
            }

            k = i;l = j;
            while(k>=0 && l < n)
            {
                if (board[k, l] == 1)
                    return false;
                k--;l++;
            }
            return true;
        }

        private int isSafer(int[,] board, int i, int j, int n)
        {
            //ther should not be any queen in the column 
            for (int m = 0; m < i; m++)
            {
                if (board[m, j] == 1)
                    return 0;
            }

            //check for left diagonal
            int k = i, l = j;
            while (k >= 0 && l >= 0)
            {
                if (board[k, l] == 1)
                    return 0;

                k--; l--;
            }

            k = i; l = j;
            while (k >= 0 && l < n)
            {
                if (board[k, l] == 1)
                    return 0;
                k--; l++;
            }
            return 1;
        }


        int counter = 0;
        private void solveNQueensWaysRecursive(int[,] board, int i, int n)
        {
            if (i == n)
            {
                counter++;               
                return;
            }


            for (int j = 0; j < n; j++)
            {
                if (isSafe(board, i, j, n))
                {
                    board[i, j] = 1;
                    solveNQueensWaysRecursive(board, i + 1, n);
                    board[i, j] = 0;
                }
                
            }           
        }

        public int solveQueensCountWays(int[,] board, int i,  int n)
        {
           
            if(i == n)
            {
                printBoard(board,n);
                Console.WriteLine("------------------");                            
                return 1 ;
            }

            int count = 0;
            for(int j =0; j< n; j++)
            {
                if (isSafer(board, i, j, n) == 1)
                {
                    board[i, j] = 1;              
                    count +=  solveQueensCountWays(board, i + 1, n);
                    board[i, j] = 0;                   
                }
                         
            }
            return count;
        }
        
    }
}
