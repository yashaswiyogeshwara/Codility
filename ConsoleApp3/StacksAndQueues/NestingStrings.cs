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
//            // int[] P = { 1,5,2,1,4,0};
//            string s = "[{()()()(){}(){{{([[()]])}}}()()}]";
//            int result = sln.solution(s);

//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(string S)
//        {
//            //{[{()}]()()[]} = 14
//            //1, N-1-1
//            //
//            Stack<char> stack = new Stack<char>();
//            foreach (char s in S)
//            {
//                switch (s)
//                {
//                    case ')':
//                        if (stack.Count == 0 || stack.Pop() != '(')
//                        {
//                            return 0;
//                        }
//                        break;
//                    case '}':
//                        if (stack.Count == 0 || stack.Pop() != '{')
//                        {
//                            return 0;
//                        }
//                        break;
//                    case ']':
//                        if (stack.Count == 0 || stack.Pop() != '[')
//                        {
//                            return 0;
//                        }
//                        break;
//                    default:
//                        stack.Push(s);
//                        break;
//                }
//            }
//            return stack.Count == 0 ? 1 : 0;
//        }


//    }
//}


