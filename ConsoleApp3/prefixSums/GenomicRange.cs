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
//            int[] P = { 5 };
//            int[] Q = { 5 };
//            string s = "CAGCCTA";
//            int[] result = sln.solution(s, P, Q);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {

//        public int[] solution(string S, int[] P, int[] Q)
//        {
//            Dictionary<string, int> dnaDict = new Dictionary<string, int>() {
//                { "A", 1},
//                { "C",2 },
//                { "G", 3},
//                { "T", 4}
//            };
//            int[] seq = S.Select(x => dnaDict[x.ToString()]).ToArray();

//            int[] resultArr = new int[P.Length];
//            for (int i = 0; i < P.Length; i++)
//            {

//                int factor = seq.Where((x, index) => index >= P[i] && index <= Q[i]).Min();
//                resultArr[i] = factor;
//            }
//            return resultArr;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }
//}


