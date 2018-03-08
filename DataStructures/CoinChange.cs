using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class CoinChange : IAlgorithm
    {
        public void Run()
        {
            // int[] arr={2,3,5,6,7,8};
            // int amount=10;
            
            int[] arr={1, 2, 3};
            int amount=5;

            long ways=FindChange(arr,amount,0);
            Console.WriteLine(ways);
            
            ways=FindChangeUsingDP(arr,amount,0,new Dictionary<string,long>());
            Console.WriteLine(ways);
        }

        private long FindChange(int[] coins, int remainingAmount, int idx)
        {
            if(remainingAmount==0)
            {
                return 1;
            }
            if(idx>=coins.Length)
            {
                return 0;
            }

            int totalAmount=0;
            long numberOfWays=0;
            while(totalAmount<=remainingAmount)
            {
                int remaining=remainingAmount-totalAmount;
                numberOfWays+=FindChange(coins,remaining,idx+1);
                totalAmount+=coins[idx];
            }
            return numberOfWays;
        }

        private long FindChangeUsingDP(int[] coins, int remainingAmount, int idx,Dictionary<string,long> memo)
        {
            if(remainingAmount==0)
            {
                return 1;
            }
            if(idx>=coins.Length)
            {
                return 0;
            }

            string key=remainingAmount+"-"+idx;
            if(memo.ContainsKey(key))
            {
                return memo[key];
            }

            int totalAmount=0;
            long numberOfWays=0;
            while(totalAmount<=remainingAmount)
            {
                int remaining=remainingAmount-totalAmount;
                numberOfWays+=FindChangeUsingDP(coins,remaining,idx+1,memo);
                totalAmount+=coins[idx];

            }

            memo.Add(key,numberOfWays);
            return numberOfWays;
        }
    }
}