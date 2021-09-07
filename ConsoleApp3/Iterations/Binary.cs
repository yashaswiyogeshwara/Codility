//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp3.txn
//{
//    //1:54 - 1:34
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution sln = new Solution();
//            int result = sln.solution(25);
//            Console.WriteLine(result);

//        }
//    }
//    class Solution
//    {
//        public int solution(int N)
//        {
//            string n_str = Convert.ToString(N, 2);
//            int lastIndexOf1 = n_str.LastIndexOf('1');
//            n_str = n_str.Substring(0, lastIndexOf1 + 1);
//            string[] strArr = n_str.Split('1').Where(x => x != "1").ToArray();
//            int maxLength = 0;
//            foreach (string s in strArr)
//            {
//                maxLength = maxLength >= s.Length ? maxLength : s.Length;
//            }
//            return maxLength;
//        }

//    }


//}


