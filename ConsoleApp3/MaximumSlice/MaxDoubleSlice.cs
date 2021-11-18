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
//            int result = sln.solution(A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int max = 0;
//            for (int x = 0; x < A.Length; x++)
//            {
//                for (int y = x + 1; y < A.Length; y++)
//                {
//                    for (int z = y + 1; z < A.Length; z++)
//                    {
//                        int sum = Sum(A, x, y) + Sum(A, y, z);
//                        max = max > sum ? max : sum;
//                    }
//                }
//            }
//            return max;
//        }

//        public int Sum(int[] Arr, int a, int b)
//        {
//            int sum = 0;
//            for (int i = a + 1; i < b; i++)
//            {
//                sum += Arr[i];
//            }
//            return sum;
//        }

//    }
//}


