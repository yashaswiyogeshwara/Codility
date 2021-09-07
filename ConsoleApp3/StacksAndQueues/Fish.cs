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
//            int[] A = { 10, 5, 6, 1, 4, 0 };
//            int[] B = { 1, 1, 0, 0, 0, 0 };
//            int result = sln.solution(A, B);

//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A, int[] B)
//        {
//            int result = A.Length;

//            Stack<int> ds = new Stack<int>();
//            for (int p = 0; p < A.Length; p++)
//            {
//                if (B[p] == 1)
//                {
//                    ds.Push(A[p]);
//                }
//                else
//                {
//                    while (ds.Count > 0)
//                    {
//                        int dsf = ds.Count > 0 ? ds.Peek() : -1;
//                        int usf = A[p];
//                        if (dsf > usf)
//                        {
//                            result--;
//                            break;
//                        }
//                        else if (dsf < usf)
//                        {
//                            result--;
//                            ds.Pop();
//                        }
//                    }
//                }
//            }
//            return result;
//        }
//    }
//}


