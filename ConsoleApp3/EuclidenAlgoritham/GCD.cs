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
//            int[] P = { 1, 4, 16 };
//            int[] Q = { 26, 10, 20 };
//            int result = sln.solution(5, 7);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int N, int M)
//        {
//            int hcf = GCF(N, M);
//            return Math.Abs(N / hcf);
//        }

//        public int GCF(int a, int b)
//        {
//            int rem = a % b;
//            if (rem == 0)
//            {
//                return b;
//            }
//            return GCF(b, a % b);
//        }
//    }
//}

