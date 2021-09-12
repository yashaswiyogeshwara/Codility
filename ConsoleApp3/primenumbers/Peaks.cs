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
//            /*
//    1,
//    5,
//    3,
//    4,
//    3,
//    4,
//    1,
//    2,
//    3,
//    4,
//    6,
//    2
//             */
//            int[] A1 = {
//    1,
//    2,
//    3,
//    4,
//    3,
//    4,
//    1,
//    2,
//    3,
//    4,
//    6,
//    2
//            };
//            int[] A = { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {

//            List<int> pa = new List<int>();
//            for (int i = 1; i < A.Length - 1; i++)
//            {
//                if (A[i] > A[i - 1] && A[i] > A[i + 1])
//                {
//                    pa.Add(i);
//                }
//            }
//            if (pa.Count < 2)
//            {
//                return pa.Count;
//            }
//            for (int i = pa.Count; i > 0; i--)
//            {
//                if (A.Length % i == 0)
//                {
//                    int slotSize = A.Length / i;
//                    bool isSlotSize = true;
//                    for (int j = 0; j < i; j++)
//                    {
//                        int b = j * slotSize;
//                        int e = (j + 1) * slotSize - 1;
//                        if (b <= pa[j] && pa[j] <= e)
//                        {
//                            continue;
//                        }
//                        else
//                        {
//                            isSlotSize = false;
//                            break;
//                        }
//                    }
//                    if (isSlotSize)
//                    {
//                        return i;
//                    }
//                }
//            }
//            return 0;
//        }

//    }
//}


