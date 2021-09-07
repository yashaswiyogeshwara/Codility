//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp3.txn
//{
//    1:55 - 1:35
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution sln = new Solution();
//            int[] A = { 5, 5, 5, 5, 5, 5 };
//            int result = sln.solution(5, A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int X, int[] A)
//        {
//            int[] allIndexes = Enumerable.Range(1, X).ToArray();
//            int[] indexArr = new int[X];
//            for (int i = 1; i < X + 1; i++)
//            {
//                indexArr[i - 1] = Array.IndexOf(A, i);
//            }
//            if (indexArr.Min() > -1)
//            {
//                return indexArr.Max();
//            }
//            else
//            {
//                return -1;
//            }
//            write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }





//}


