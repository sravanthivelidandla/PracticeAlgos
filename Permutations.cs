using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PracticeAlgos
{
    //https://www.youtube.com/watch?v=gDGw0cvFXPQ&list=PL9gnSGHSqcnr_DxHsP7AW9ftq0AtAyYqJ&index=29 //kunal
    public class Permutation
    {
        public void printPermutationsOfString(string input)
        {
            List<string> permutations = printHelper(input, "", new List<string>());
            permutations.ForEach(p => Console.WriteLine(p));
            Console.WriteLine(countHelper(input, ""));
        }

        
        public List<string> printHelper(string input, string permutation, List<string> permutations)
        {
            if(input.Length == 0)
            {
                permutations.Add(permutation);
                return permutations;
            }

            char ch = input[0];
            for(int i = 0; i<= permutation.Length; i++)
            {
                string first = permutation.Substring(0, i);
                string end = permutation.Substring(i);
                printHelper(input.Substring(1), first + ch + end,permutations);
            }

            return permutations;
        }

        public int countHelper(string input, string permutation)
        {
            int count = 0;

            if (input.Length == 0)
            {
               return 1;
            }

            char ch = input[0];
            for (int i = 0; i <= permutation.Length; i++)
            {
                string first = permutation.Substring(0, i);
                string end = permutation.Substring(i);
                count = count+countHelper(input.Substring(1), first + ch + end);
            }

            return count;
        }
    }
}
