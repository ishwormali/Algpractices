using System;
using DataStructures;
using OOP;
namespace AlgPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // IAlgorithm a;


            // IAlgorithm algorithm=new ReverseString();
            // IAlgorithm algorithm=new Palindrome();
            // IAlgorithm algorithm=new RemoveDuplicateChar();
            // IAlgorithm algorithm=new HighestOccuredChar();
            // IAlgorithm algorithm=new FindHighestInArray();
            // IAlgorithm algorithm=new AbstractClassTest();
            // IAlgorithm algorithm=new ArrayLeftRotation();
            // IAlgorithm algorithm=new TriesContact();
           
            IAlgorithm algorithm=new Staircase();

            algorithm.Run();

            Console.ReadLine();
              // int i=10;
            // Console.WriteLine(++i);
            // int j=15;
            // Console.WriteLine(j++);
            // Console.WriteLine(j);
        }


        static void BitTest()
        {
            int a=2;
            for(int i=0;i<10;i++)
            {   
                Console.WriteLine(Convert.ToString(a,2));
                a=a>>1;
                
            }
        }
    }

}
