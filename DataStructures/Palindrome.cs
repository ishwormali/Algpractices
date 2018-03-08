using System;

namespace DataStructures
{
    public class Palindrome : IAlgorithm
    {
        public void Run()
        {
            string[] sources=new string[]{"blaaaalb","blacalb","abcabc"};
            foreach(string str in sources)
            {
                
                bool isPalindrome=WithoutReverse(str);
                bool testResult=UsingReverse(str);
                Console.WriteLine($"{str} ={isPalindrome} = {isPalindrome==testResult}");
            }
            
        }

        public bool WithoutReverse(string str)
        {
            int min=0;
            int max=str.Length-1;
            while(true)
            {
                if(min>max)
                {
                    return true;
                }
                if(Char.ToLowerInvariant(str[min])!=Char.ToLowerInvariant(str[max]))
                {
                    return false;

                }
                min++;
                max--;
            }
        }

        public bool UsingReverse(string str)
        {
            
            char[] arr=str.ToCharArray();
            Array.Reverse(arr);
            return string.Equals(str,new string(arr),StringComparison.OrdinalIgnoreCase);


        }
    }
}