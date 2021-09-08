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
//            int[] A = { 1, 2, 0, 2 };
//            int[] A1 = { 8, 8, 8, 9, 8, 8, 7, 7, 7, 7, 77, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public class N
//        {
//            public int V { get; set; }
//            public int C { get; set; }
//        }
//        public int solution(int[] A)
//        {
//            int[] dis = A.Distinct().ToArray();
//            Dictionary<int, int> ca = A.Distinct().Select(x => {
//                int c = A.Count(k => k == x);
//                return new N() { V = x, C = c };
//            }).ToDictionary(k => k.V, k => k.C);
//            float half = A.Length / 2;
//            KeyValuePair<int, int> domin = ca.Where(x => x.Value > half).FirstOrDefault();
//            if (domin.Value > 0)
//            {
//                return Array.IndexOf(A, domin.Key);
//            }
//            else
//            {
//                return -1;
//            }
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }
//}


