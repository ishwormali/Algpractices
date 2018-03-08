using System;

namespace DataStructures
{
    public class ReverseString:IAlgorithm
    {
        public void Run()
        {
            Console.WriteLine("Reverse string");
            string str="makeashift";
            Console.WriteLine(str);
            string rev=Reverse(str);
            Console.WriteLine(rev);
            var test1=str.ToCharArray();
            Array.Reverse(test1);
            Console.WriteLine($"Test {rev==new string(test1)}");
        }

        private string Reverse(string str)
        {
            string reverseString=string.Empty;
            for(int i=str.Length-1;i>=0;i--)
            {
                reverseString+=str.Substring(i,1); //or str[i];

            }

            return reverseString;
        }

        

        
    }
}