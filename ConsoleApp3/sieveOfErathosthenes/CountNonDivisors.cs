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
//            int[] A = { 3, 1, 2, 3, 6 };
//            Solution sln = new Solution();
//            int[] result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {

//        public int[] solution(int[] A)
//        {
//            int[] d = new int[A.Length];
//            for (int i = 0; i < A.Length; i++)
//            {
//                int c = GetNonDivCount(A, A[i]);
//                d[i] = c;
//            }
//            return d;
//        }
//        public int GetNonDivCount(int[] A, int num)
//        {
//            int K = 0;
//            for (int i = 0; i < A.Length; i++)
//            {
//                int den = A[i];
//                if (num != den)
//                {
//                    if (num > den)
//                    {
//                        if (num % den != 0)
//                        {
//                            K++;
//                        }
//                    }
//                    else
//                    {
//                        K++;
//                    }
//                }
//            }
//            return K;
//        }

//    }
//}

