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
//            List<int> A1 = new List<int> { 0, 0, 0, 1, 1, 2, 2, 2, 1, 3, 5, 6, 2 };
//            int result = sln.sockMerchant(1, A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int sockMerchant(int n, List<int> ar)
//        {
//            int result = 0;
//            var dar = ar.Distinct().ToList();
//            foreach (int i in dar)
//            {
//                int c = ar.Where(x => x == i).Count();
//                int pair = c / 2;
//                result += pair;
//            }
//            return result;
//        }

//    }
//}


