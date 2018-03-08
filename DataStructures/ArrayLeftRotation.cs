using System;

namespace DataStructures
{
    public class ArrayLeftRotation : IAlgorithm
    {
        public void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            Rotate(a,a.Length,6);
        }

        private void Rotate(int[] arr, int count, int r)
        {
            int rl=count-r;
            int[] newArr=new int[count];
            for(int i=0;i<rl;i++)
            {
                newArr[i]=arr[r+i];
            }
            for(int i=0;i<r;i++)
            {
                newArr[rl+i]=arr[i];
            }

            Console.WriteLine(string.Join(" ",newArr));
            
        }

    }

    
}