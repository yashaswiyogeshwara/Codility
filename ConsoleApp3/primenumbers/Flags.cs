/*
 wrong answer. Did not pass few test cases.
 */
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
//            /*
//    1,
//    5,
//    3,
//    4,
//    3,
//    4,
//    1,
//    2,
//    3,
//    4,
//    6,
//    2
//             */
//            int[] A1 = {
//            1,
//    5,
//    3,
//    4,
//    3,
//    4,
//    1,
//    2,
//    3,
//    4,
//    6,
//    2
//            };
//            int[] A = { 0, 0, 0, 0, 0, 1, 0, 1, 0, 1 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {

//            List<int> pa = new List<int>();
//            for (int i = 1; i < A.Length - 1; i++)
//            {
//                if (A[i] > A[i - 1] && A[i] > A[i + 1])
//                {
//                    pa.Add(i);
//                }
//            }
//            if (pa.Count < 3)
//            {
//                return pa.Count;
//            }
//            int result = 2;
//            for (int j = 3; j <= pa.Count; j++)
//            {
//                int next = pa[0];
//                for (int k = 1; k < j; k++)
//                {
//                    next = pa.Where(x => x > next + j).FirstOrDefault();
//                    if (next > 0)
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        return result;
//                    }
//                }
//                result = j;
//            }
//            return result;
//        }

//    }
//}


