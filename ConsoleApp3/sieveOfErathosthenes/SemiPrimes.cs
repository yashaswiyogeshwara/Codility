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
//            int[] A = { 3, 1, 2, 3, 6 };
//            Solution sln = new Solution();
//            int[] P = { 1, 4, 16 };
//            int[] Q = { 26, 10, 20 };
//            int[] result = sln.solution(26, P, Q);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int[] solution(int N, int[] P, int[] Q)
//        {
//            int[] r = new int[P.Length];
//            List<int> pr = GetPrimes(N);
//            List<int> sp = GetSP(pr, N);
//            for (int i = 0; i < P.Length; i++)
//            {
//                int c = sp.Where(x => x >= P[i] && x <= Q[i]).Count();
//                r[i] = c;
//            }
//            return r;
//        }

//        public List<int> GetSP(List<int> pr, int N)
//        {
//            List<int> sp = new List<int>();
//            foreach (int i in pr)
//            {
//                foreach (int j in pr)
//                {
//                    if ((i * j) <= N && !sp.Contains(i * j))
//                    {
//                        sp.Add(i * j);
//                    }
//                }
//            }
//            return sp;
//        }
//        public List<int> GetPrimes(int b)
//        {
//            List<int> r = new List<int>();
//            for (int i = 2; i <= b; i++)
//            {
//                if (isPrime(i))
//                {
//                    r.Add(i);
//                }
//            }
//            return r;
//        }

//        public bool isPrime(int n)
//        {
//            if (n == 2)
//            {
//                return true;
//            }
//            double sq = Math.Sqrt(n);
//            for (int i = 2; i < sq + 1; i++)
//            {
//                if (n % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

