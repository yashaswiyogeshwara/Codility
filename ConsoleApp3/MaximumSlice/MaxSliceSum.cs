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
//            /*
//                23171
//                21011,
//                21123,
//                21366,
//                21013,
//                21367,
//             */
//            Solution sln = new Solution();
//            int[] A1 = { -1000, -20000 };
//            int result = sln.solution(A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {

//            int max = A[0];
//            int len = A.Length;
//            if (len == 1)
//            {
//                return A[0];
//            }
//            for (int i = 0; i < A.Length; i++)
//            {
//                int k = i;
//                int sum = 0;
//                while (k >= 0)
//                {
//                    sum = A[k] + sum;
//                    max = sum > max ? sum : max;
//                    k--;
//                }
//            }
//            return max;
//        }
//    }
//}


