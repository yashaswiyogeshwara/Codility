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
//            int[] A1 = { -10000, 0, 0, 0, 0, 0, 10000, 0, 0, 0, 0, 25, 10000, 3 };
//            int result = sln.solution(6);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int N)
//        {
//            int fac = 1;
//            for (int i = 2; i < N + 1; i++)
//            {
//                if (N % i == 0)
//                {
//                    fac++;
//                }
//            }
//            return fac;
//        }

//    }
//}


