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
//            int[] result = sln.solution(25);
//            Console.WriteLine(result);

//        }
//    }
//    class Solution
//    {
//        public int[] solution(int[] A, int K)
//        {
//            int rotationTimes = 0;
//            if (A.Length > 0 && K > A.Length)
//            {
//                rotationTimes = K % A.Length;
//            }
//            else
//            {
//                rotationTimes = K;
//            }
//            return GetRotatedArray(A, rotationTimes);
//        }

//        public int[] GetRotatedArray(int[] A, int K)
//        {

//            int[] frontArray = A.Skip(A.Length - K).ToArray();
//            int[] backArray = A.Take(A.Length - K).ToArray();
//            return frontArray.Concat(backArray).ToArray();
//        }
//    }


//}


