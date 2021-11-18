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
//            int[] A = { -1000000000, -1000000000 };
//            int[] A1 = { 8, 8, 8, 9, 8, 8, 7, 7, 7, 7, 77, 7, 7, 7, 7, 7, 7, 7, 7, 7, 8 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int result = 0;
//            int? l = GetLeader(A, 0, A.Length);
//            if (l != null)
//            {
//                for (int i = 0; i < A.Length - 1; i++)
//                {
//                    int? preL = GetLeader(A, 0, i + 1);
//                    int? posL = GetLeader(A, i + 1, A.Length);
//                    if (preL != null && posL != null && preL == posL)
//                    {
//                        result++;
//                    }
//                }
//            }
//            return result;
//        }
//        public int? GetLeader(int[] A, int j, int k)
//        {
//            // (4,3, 4, 4, 4, 2) 
//            Stack<int> s = new Stack<int>();
//            for (int i = j; i < k; i++)
//            {
//                if (s.Count > 0)
//                {
//                    if (s.Peek() != A[i])
//                    {
//                        s.Pop();
//                    }
//                    else
//                    {
//                        s.Push(A[i]);
//                    }
//                    continue;
//                }
//                s.Push(A[i]);
//            }
//            bool v = s.Count > 0;
//            if (s.Count > 0)
//            {
//                float h = (float)(k - j) / (float)2;
//                int c = CopyArray(A, j, k).Count(x => x == s.Peek());
//                if (c > h)
//                {
//                    return s.Peek();
//                }
//            }
//            return null;
//        }

//        public int[] CopyArray(int[] A, int j, int k)
//        {
//            int[] n = new int[k - j];
//            int ind = 0;
//            for (int i = j; i < k; i++)
//            {
//                n[ind] = A[i];
//                ind++;
//            }
//            return n;
//        }
//    }
//}


