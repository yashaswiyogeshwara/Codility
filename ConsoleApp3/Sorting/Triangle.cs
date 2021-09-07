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
//            int[] P = { (int.MaxValue - 7) + 5, (int.MaxValue - 7) + 6, (int.MaxValue - 7) + 7 };
//            int result = sln.solution(P);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            A = A.OrderBy(x => x).ToArray();
//            List<int[]> tpl = new List<int[]>();
//            for (int i = 0; i < A.Length; i++)
//            {
//                if (i + 2 < A.Length)
//                {
//                    long[] arr = { A[i], A[i + 1], A[i + 2] };
//                    bool result = IsTriangle(arr);
//                    if (result)
//                    {
//                        return 1;
//                    }
//                    else
//                    {
//                        continue;
//                    }
//                }
//            }
//            return 0;
//        }

//        public bool IsTriangle(long[] arr)
//        {
//            return (arr[0] + arr[1]) > arr[2] && (arr[0] + arr[2]) > arr[1] && (arr[1] + arr[2]) > arr[0];
//        }
//    }
//}


