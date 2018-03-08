using System;

namespace DataStructures
{
    public class Staircase : IAlgorithm
    {
        public void Run()
        {
            int stairs=30;
            Console.WriteLine("Calculating");
            int steps = 0;

            steps = FindDPWrapper(stairs);
            Console.WriteLine("Calculating using dp : " + steps);

            steps = Find(stairs);
            Console.WriteLine("Calculating without dp : "+steps);
            
            Console.WriteLine(steps);
            
        }

        public int Find(int steps)
        {
            if(steps<0)
            {
                return 0;
            }
            else if(steps==0)
            {
                return 1;
            }

            return Find(steps-1)+Find(steps-2)+Find(steps-3);
        }

        public int FindDPWrapper(int steps)
        {
            return FindDP(steps, new int[steps + 1]);

        }
        public int FindDP(int steps, int[] memo)
        {
            if(steps<0)
            {
                return 0;
            }
            else if(steps==0)
            {
                return 1;
            }

            if(memo[steps]==0)
            {
                memo[steps]= FindDP(steps - 1,memo) + FindDP(steps - 2,memo) + FindDP(steps - 3,memo);
            }

            return memo[steps];

        }
    }
}