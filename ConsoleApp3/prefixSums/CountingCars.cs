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
//            int[] A = { 1, 1, 1, 1 };
//            int result = sln.solution(A);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] A)
//        {
//            int[] eastCars = A.Select((x, index) =>
//            {
//                if (x == 0)
//                {
//                    return index;
//                }
//                else
//                {
//                    return -1;
//                }
//            }).Where((x) => x >= 0).ToArray();

//            int[] westCars = A.Select((x, index) =>
//            {
//                if (x == 1)
//                {
//                    return index;
//                }
//                else
//                {
//                    return -1;
//                }
//            }).Where((x) => x >= 0).ToArray();
//            int result = 0;
//            foreach (int i in eastCars)
//            {
//                int westcarCount = westCars.Where(x => x > i).Count();
//                result += westcarCount;
//            }
//            return result > 1000000000 ? -1 : result;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }





//}


