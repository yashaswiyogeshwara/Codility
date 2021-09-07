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
//            int[] P = { 1, 5, 2, 1, 4, 0 };
//            int result = sln.solution(P);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public class circle
//        {
//            public int r { get; set; }
//            public int c { get; set; }

//            public int[] GetRange()
//            {
//                int[] range = { c - r, c + r };
//                return range;
//            }

//        }
//        public int solution(int[] A)
//        {
//            int intersections = 0;
//            List<circle> circles = A.Select((x, index) => new circle() { r = x, c = index }).Where(x => x.r > 0).OrderByDescending(x => x.r).ToList();
//            for (int i = 0; i < circles.Count; i++)
//            {
//                circle big = circles[i];
//                for (int j = i + 1; j < circles.Count; j++)
//                {
//                    circle small = circles[j];
//                    if (IsIntersection(big, small))
//                    {
//                        intersections++;
//                    }
//                }
//            }
//            if (intersections > 10000000)
//            {
//                intersections = -1;
//            }
//            return intersections;
//        }
//        public bool IsIntersection(circle b, circle s)
//        {
//            int[] s_range = s.GetRange();
//            int[] b_range = s.GetRange();
//            if ((b_range[0] <= s_range[0] && s_range[0] <= b_range[1]) || (b_range[0] <= s_range[1] && s_range[1] <= b_range[1]))
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }


//        }
//    }
//}


