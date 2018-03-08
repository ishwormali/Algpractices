using System;

namespace DataStructures
{
    public class PrintFibonacci : IAlgorithm
    {
        public void Run()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int ret=FindSum(n);
            Console.WriteLine(n);
        }

        public int FindSum(int n)
        {
            if(n==0)
                return 0;
            if(n==1)
                return n;
            return FindSum(n-1)+FindSum(n-2);
        }
    }
}