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
//            int result = sln.solution(101);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int N)
//        {
//            /*
//             If there are n factors from 1 to |sqrt(n)|(inclusive)
//            then there are n factores from |sqrt(n)|+1 to N(inclusive)

//             */
//            if (N == 1)
//            {
//                return 4;
//            }
//            double sq = Math.Sqrt(N);
//            int absSq = (int)Math.Abs(sq);
//            if (absSq - sq == 0)
//            {
//                return 4 * (absSq);
//            }
//            int fac = 0;
//            for (int i = absSq; i >= 1; i--)
//            {
//                if (N % i == 0)
//                {
//                    fac = i;
//                    break;
//                }
//            }
//            int otherFac = N / fac;
//            return 2 * (fac + otherFac);
//        }

//    }
//}


