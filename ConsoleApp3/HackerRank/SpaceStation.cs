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
//            int[] A1 = { 0, 4 };
//            int result = sln.flatlandSpaceStations(6, A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int flatlandSpaceStations(int n, int[] c)
//        {
//            int[] minA = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                int[] minL = new int[c.Length];
//                for (int j = 0; j < c.Length; j++)
//                {
//                    int delta = Math.Abs(i - c[j]);
//                    minL[j] = delta;
//                }
//                minA[i] = minL.Min();
//            }
//            return minA.Max();

//        }
//    }
//}


