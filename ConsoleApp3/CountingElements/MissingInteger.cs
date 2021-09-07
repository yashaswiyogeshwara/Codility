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
//            int[] A = { -1, -2, 2, 3, 4, 4, 4, 2, 2, 2, 5 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int max = 0;
//            for (int i = 1; i <= A.Length; i++)
//            {
//                if (Array.IndexOf(A, i) == -1)
//                {
//                    return i;
//                }
//                max = max >= A[i - 1] ? max : A[i - 1];
//            }
//            return max + 1;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }





//}


