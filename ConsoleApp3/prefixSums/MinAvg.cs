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
//            int[] P = { 10, 10, -1, 2, 4, -1, 2, -1 };
//            int result = sln.solution(P);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int[] preFixArr { get; set; }
//        public int solution(int[] A)
//        {
//            //0,1,2
//            /*
//             0,1
//            0,2
//            1,2
//             */
//            float minAvg = 0;
//            int minP = int.MaxValue;
//            preFixArr = GetPreArr(A);
//            for (int p = 0; p < A.Length; p++)
//            {
//                for (int q = p + 1; q < A.Length; q++)
//                {
//                    float avg = (float)GetSum(p, q) / (float)(q - p + 1);
//                    if (p == 0 && q == 1)
//                    {
//                        minAvg = avg;
//                        minP = p;
//                    }
//                    else
//                    {
//                        if (avg == minAvg)
//                        {
//                            minP = p < minP ? p : minP;
//                        }
//                        if (avg < minAvg)
//                        {
//                            minAvg = avg;
//                            minP = p;
//                        }

//                    }
//                }
//            }
//            return minP;
//        }

//        public int GetSum(int p, int q)
//        {
//            return p > 0 ? preFixArr[q] - preFixArr[p - 1] : preFixArr[q];
//        }
//        public int[] GetPreArr(int[] A)
//        {
//            int[] arr = new int[A.Length];
//            arr[0] = A[0];
//            for (int i = 1; i < A.Length; i++)
//            {
//                arr[i] = A[i] + arr[i - 1];
//            }
//            return arr;
//        }

//    }
//}


