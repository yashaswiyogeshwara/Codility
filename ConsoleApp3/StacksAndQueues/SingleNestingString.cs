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
//            string s = "";
//            int result = sln.solution(s);

//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(string S)
//        {
//            Stack<char> openingBraces = new Stack<char>();
//            foreach (char s in S)
//            {
//                switch (s)
//                {
//                    case '(':
//                        openingBraces.Push(s);
//                        break;
//                    default:
//                        if (openingBraces.Count > 0)
//                        {
//                            openingBraces.Pop();
//                            break;
//                        }
//                        else
//                        {
//                            return 0;
//                        }
//                }
//            }
//            return openingBraces.Count == 0 ? 1 : 0;
//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }
//}


