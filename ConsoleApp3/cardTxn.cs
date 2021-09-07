//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp3.kxr
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Solution sln = new Solution();

//            int[] A = { 180, -50, -25, -25 };
//            string[] D = { "2020-01-01", "2020-01-01", "2020-01-01", "2020-01-31" };
//            sln.solution(A, D);
//        }
//    }
//    public class Txn
//    {
//        public string month { get; set; }
//        public int amount { get; set; }
//    }
//    class Solution
//    {

//        public int solution(int[] A, string[] D)
//        {
//            int transactionSum = A.Sum();
//            int totalNoOfValidCardTxns = 0;
//            Console.WriteLine("transactionSum " + transactionSum.ToString());
//            int[] cardTransactions = A.Select(x =>
//            {
//                if (x < 0)
//                {
//                    return x;
//                }
//                else
//                {
//                    return 0;
//                }
//            }).ToArray();
//            List<Txn> cardTransactionMonthList = new List<Txn>();
//            if (cardTransactions.Where(x => x < 0).ToArray().Length >= 3)
//            {

//                for (int i = 0; i < cardTransactions.Length; i++)
//                {
//                    if (cardTransactions[i] < 0)
//                    {
//                        string m = D[i].Substring(5, 2);

//                        cardTransactionMonthList.Add(new Txn() { month = m, amount = cardTransactions[i] });
//                    }
//                }
//                var noOfValidCardTxnMonths = cardTransactionMonthList.GroupBy(x => x.month);
//                foreach (var g in noOfValidCardTxnMonths)
//                {
//                    int cardSum = 0;
//                    int noOfValidCardTxnsPerMonth = 0;
//                    foreach (Txn t in g)
//                    {
//                        cardSum += t.amount;
//                        noOfValidCardTxnsPerMonth++;
//                    }
//                    if (cardSum <= -100 && noOfValidCardTxnsPerMonth >= 3)
//                    {
//                        totalNoOfValidCardTxns++;
//                    }
//                }
//            }
//            Console.WriteLine(totalNoOfValidCardTxns);
//            int result = transactionSum - (5 * 12) + (totalNoOfValidCardTxns * 5);
//            return result;
//        }
//    }
//}


