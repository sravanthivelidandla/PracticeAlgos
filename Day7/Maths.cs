using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.Day7
{
    public class Maths
    {
        public void printFibonacci(int n, List<int> dp)
        {
            if (n == 0) Console.Write(0);
            if (n == 1) Console.Write(1);

            Console.Write(0);
            for (int i = 2; i< n; i++)
            {
                Console.Write((i - 2) + (i - 1));
            }
            
        }
        public int getFibonacci(int n,List<int> dp)
        {
            if (n == 0)
            {                
                return 0;
            }
            if (n == 1)
                return 1;

            if (dp.Count > n)
                return dp[n];
            else
            {
               int number = getFibonacci(n - 1, dp) + getFibonacci(n - 2, dp);
                dp.Insert(n, number);
                return dp[n];
            }
           
        }

        public int GCD(int a , int b)
        {
            if (a == 0) return b;
           return GCD(b % a, a);
        }

        public int LCM (int a, int b)
        {
            return ((a * b) / GCD(a, b));
        }
    }
}
