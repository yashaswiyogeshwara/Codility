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
//            int[] A = { 8, 8, 8, 7, 9, 8, 7, 4, 8 };
//            int[] A1 = { 8, 8, 8, 9, 8, 8, 7 };
//            int result = sln.solution(A1);
//            Console.WriteLine(result);
//        }
//    }
//    class Solution
//    {
//        public int solution(int[] H)
//        {
//            int minBlocks = 0;
//            Queue<int> blockStack = new Queue<int>();
//            for (int b = 0; b < H.Length; b++)
//            {
//                if (b == 0)
//                {
//                    blockStack.Enqueue(H[b]);
//                    minBlocks++;
//                    continue;
//                }
//                int prevBlockBase = blockStack.Peek();
//                if (H[b - 1] == H[b])
//                {
//                    continue;
//                }
//                if (H[b] < H[b - 1])
//                {
//                    if (H[b] < prevBlockBase)
//                    {
//                        blockStack = new Queue<int>();
//                        blockStack.Enqueue(H[b]);
//                        minBlocks++;
//                    }
//                    else
//                    {
//                        bool sameBlockExistsInStack = false;
//                        foreach (int sb in blockStack)
//                        {
//                            if (sb == H[b])
//                            {
//                                sameBlockExistsInStack = true;
//                            }
//                        }
//                        if (sameBlockExistsInStack)
//                        {
//                            continue;
//                        }
//                        else
//                        {
//                            minBlocks++;
//                            blockStack.Enqueue(H[b]);
//                            continue;
//                        }
//                    }
//                }
//                if (H[b] > H[b - 1])
//                {
//                    blockStack.Enqueue(H[b]);
//                    minBlocks++;
//                    continue;
//                }
//            }
//            return minBlocks;
//        }
//    }
//}


