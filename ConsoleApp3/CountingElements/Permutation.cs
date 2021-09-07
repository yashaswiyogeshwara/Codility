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
//            int[] A = { 1, 2, 3 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            A = A.OrderBy(x => x).ToArray();
//            for (int i = 0; i < A.Length; i++)
//            {
//                if ((i + 1) != A[i])
//                {
//                    return 0;
//                }
//            }
//            return 1;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }





//}


