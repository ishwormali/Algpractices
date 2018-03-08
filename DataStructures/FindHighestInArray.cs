using   System;
using System.Collections.Generic;

namespace DataStructures
{
    /*
    Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?(Solution)
     */
    public class FindHighestInArray : IAlgorithm
    {
        public void Run()
        {
            int[][] sources={new int[]{7,3,5,4,7,2,7,7,8,7,7,7,7,7,7,7,7,7,7,7,4,7,7,5,6,5,3,4,7},
                            new int[]{8,8,5,4,7,2,7,7,8,7,7,8,8,8,8,8,8,8,8,8,4,7,7,5,6,8,8,4,8},
                            new int[]{2,3,5,4,7,2,7,7,8,7,7,7,7,7,7,4,7,7,5,6,5,3,4,7},
                            new int[]{2,3,5,4,7,2,7,7,8,7,7,2,3,3,3,3,3,3,3,3,7,7,4,7,7,5,6,5,3,4,7},
                            new int[]{2,3,5,4,7,2,7,7,8,77,4,7,7,5,6,5,3,4,7},
                            new int[]{2,2,5,2,2,2,8,2,7,2,7,7,5,2,2,2,4,7},
                            new int[]{2,3,5,7,4,7,7,5,6,5,3,4,7},
                            new int[]{2,3,5,2,3,6,6,6,6,6,7,4,7,7,5,6,5,3,4,7}};
            for(int i=0;i<sources.Length;i++)
            {
                int[] arr=sources[i];
                Console.WriteLine("\n");
                Console.WriteLine(string.Join(",",arr));
                Console.WriteLine("Unsorted array");
                FuncUnSorted(arr);
                Console.WriteLine("Sorted array");
                FuncSorted(arr);
                Console.WriteLine("Unsorted array without additional variable");
                FuncUnsortedWithoutAdditionalDS(arr);
            }
        }

        //Unsorted using dictionary
        public void FuncUnSorted(int[] arr)
        {
            int min=arr.Length/2;
            IDictionary<int,int> occurences=new Dictionary<int,int>();
            
            for(int i=0;i<arr.Length;i++)
            {
                if(occurences.ContainsKey(arr[i]))
                {
                    occurences[arr[i]]+=1;
                }
                else
                {
                    occurences.Add(arr[i],1);
                }
                if(occurences[arr[i]]>min)
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
            }

            Console.WriteLine("Non found");
            
        }

        /*
            Unsorted array without using additional data structure
         */
        public void FuncUnsortedWithoutAdditionalDS(int[] arr)
        {
            int min=arr.Length/2;
            int maxIdx=0,count=0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[maxIdx]==arr[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if(count==0)
                {
                    maxIdx=i;
                    count=1;
                }
            }

            count=0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==arr[maxIdx])
                {
                    count++;
                }
                if(count>min)
                {
                    Console.WriteLine(arr[maxIdx]);
                    return;
                }
            }
            Console.WriteLine("Not found");
        }

        public void FuncSorted(int[] arr)
        {
            int min=arr.Length/2;
            Array.Sort(arr);
            int maxIdx=0;
            int maxCount=1;
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]==arr[maxIdx])
                {
                    maxCount++;
                }

                if(maxCount>min)
                {
                    Console.WriteLine(arr[maxIdx]);
                    return;
                }
                if(arr[i]!=arr[maxIdx])
                {
                    maxCount=1;
                    maxIdx=i;
                }
                    
            }

            Console.WriteLine("Not found");
        }
    }
}