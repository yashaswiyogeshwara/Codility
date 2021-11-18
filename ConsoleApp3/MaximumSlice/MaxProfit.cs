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
//            int[] A = {    23171,
//                21011,
//                21123,
//                21366,
//                21013,
//                21367, };
//            int[] A1 = { 200000, 20, 600000 };
//            int result = sln.solution(A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int max = 0;
//            if (A.Length == 1)
//            {
//                return A[0];
//            }
//            for (int i = 0; i < A.Length; i++)
//            {
//                int k = i;
//                while (k > 0)
//                {
//                    k--;
//                    int diff = A[i] - A[k];
//                    max = diff > max ? diff : max;
//                }
//            }
//            return max < 0 ? 0 : max;
//        }

//    }
//}


