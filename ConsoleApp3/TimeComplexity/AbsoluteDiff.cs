//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp3.txn
//{
//    //1:55 - 1:35
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution sln = new Solution();
//            int[] A = { 5000, 6000 };
//            sln.solution(A);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int result = 0;
//            for (int i = 0; i < A.Length - 1; i++)
//            {
//                // int[] preArray= A.Take(i + 1).ToArray();
//                // int[] postArray = A.Skip(i + 1).ToArray();
//                double preSum = A.Take(i + 1).Sum();
//                double postSum = A.Skip(i + 1).Sum();
//                int delta = (int)Math.Abs(preSum - postSum);
//                if (i == 0)
//                {
//                    result = delta;
//                }
//                else
//                {
//                    result = result < delta ? result : delta;
//                }
//            }
//            return result;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }




//}


