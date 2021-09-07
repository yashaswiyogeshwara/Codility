//using System;
//using System.Linq;

//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "........!!!!!! t         ... ? !  R E ST ....????????";
//            Solution sln = new Solution();
//            int count = sln.solution(input);
//            Console.WriteLine(count);
//        }
//    }


//    class Solution
//    {
//        public int solution(string S)
//        {
//            string[] sentenses = S.Split(new char[] { '.', '!', '?' });
//            int maxWordCount = 0;
//            Console.WriteLine("Sentenes COunt" + sentenses.Length);
//            foreach (string str in sentenses)
//            {
//                Console.WriteLine("sentence : " + str);
//                string[] words = str.Split(' ').Where(x => x.Length > 0).ToArray();
//                printWords(words);
//                maxWordCount = words.Length > maxWordCount ? words.Length : maxWordCount;
//            }
//            return maxWordCount;
//        }

//        public void printWords(string[] str)
//        {
//            foreach (string s in str)
//            {
//                Console.WriteLine("Word : " + s);

//            }
//        }
//    }

//}
