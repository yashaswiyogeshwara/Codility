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
//            int[] P = { -10, -10, -1, -2, 4, -1, -2, -1 };
//            int result = sln.solution(P);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int[] nArr = A.Where(x => x < 0).OrderBy(x => x).ToArray();
//            int[] pArr = A.Where(x => x >= 0).OrderBy(x => x).ToArray();
//            int maxProductNeg = 0;
//            int maxProductPos = 0;
//            if (pArr.Length == 0)
//            {
//                int nArrLen = nArr.Length;
//                return nArr[nArrLen - 1] * nArr[nArrLen - 2] * nArr[nArr.Length - 3];
//            }
//            if (nArr.Length >= 2 && pArr.Length >= 1)
//            {
//                int nArrLen = nArr.Length;
//                maxProductNeg = nArr[0] * nArr[1] * pArr[pArr.Length - 1];
//            }
//            if (pArr.Length > 2)
//            {
//                int pArrLen = pArr.Length;
//                maxProductPos = pArr[pArrLen - 1] * pArr[pArrLen - 2] * pArr[pArr.Length - 3];
//            }
//            return maxProductNeg > maxProductPos ? maxProductNeg : maxProductPos;
//        }
//    }
//}


