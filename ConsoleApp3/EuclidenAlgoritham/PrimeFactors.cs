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
//            int[] P = { 15, 10, 15 };
//            int[] Q = { 75, 30, 45 };
//            int result = sln.solution(P, Q);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        private int max = 0;
//        private List<int> PrimeArr;
//        public int solution(int[] A, int[] B)
//        {
//            int count = 0;

//            for (int i = 0; i < A.Length; i++)
//            {
//                bool sameFactors = CheckPrimeFactors(A[i], B[i]);
//                if (sameFactors)
//                {
//                    count++;
//                }
//            }
//            return count;
//        }
//        public bool CheckPrimeFactors(int A, int B)
//        {
//            max = A > B ? A : B;
//            if (A == B)
//            {
//                return true;
//            }
//            GetPrimeArr();
//            int[] pa = GetPF(A).Distinct().ToArray();
//            int[] pb = GetPF(B).Distinct().ToArray();
//            if (pa.Length == pb.Length)
//            {
//                for (int k = 0; k < pa.Length; k++)
//                {
//                    if (pa[k] != pb[k])
//                    {
//                        return false;
//                    }
//                }
//                return true;
//            }
//            return false;
//        }

//        public int[] GetPF(int a)
//        {
//            List<int> pf = new List<int>();
//            int pindex = 0;
//            while (a > 1)
//            {
//                int pm = GetNextPrime(pindex);
//                int rem = a % pm;
//                if (rem == 0)
//                {
//                    a = a / pm;
//                    pf.Add(pm);
//                    continue;
//                }
//                else
//                {
//                    pindex++;
//                }
//            }
//            return pf.ToArray();
//        }

//        public int GetNextPrime(int i)
//        {
//            return PrimeArr[i];
//        }

//        public void GetPrimeArr()
//        {
//            PrimeArr = new List<int>();
//            for (int i = 2; i <= max; i++)
//            {
//                bool p = isP(i);
//                if (p)
//                {
//                    PrimeArr.Add(i);
//                }
//            }
//        }
//        public bool isP(int i)
//        {
//            if (i == 2 || i == 3)
//            {
//                return true;
//            }
//            float sq = (int)Math.Floor(Math.Sqrt(i));
//            for (int j = 2; j <= sq; j++)
//            {
//                if (i % j == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

