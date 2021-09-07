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
//            int[] A = { 1, 2, 4, 4, 4, 2, 2, 2, 5 };
//            int[] result = sln.solution(5, A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int[] solution(int N, int[] A)
//        {
//            int[] c = new int[N];
//            int maxC = 0;
//            foreach (int i in A)
//            {
//                if (i == N + 1)
//                {
//                    for (int k = 0; k < N; k++)
//                    {
//                        c[k] = maxC;
//                    }
//                }
//                else if (i < N + 1)
//                {
//                    c[i - 1]++;
//                    maxC = maxC >= c[i - 1] ? maxC : c[i - 1];
//                }
//            }
//            return c;
//        }
//    }





//}


