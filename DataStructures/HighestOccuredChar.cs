using System;
 using System.Linq;

namespace DataStructures
{
    public class HighestOccuredChar : IAlgorithm
    {
        public void Run()
        {
            string[] sources={"abcaljdfljasfljasdfjaldsfaldsuo2wirslfjlasdba","ajfwuobvkytawerqpiqewryhpqweuroquwabd,zcxbaksdfh",
                               "iruiwrowurquerowuvhkasyhfkshfoiyurc","owrulxcvnkghkfadhaksdhfweyhfksdkhf" };
            for(int i=0;i<sources.Length;i++)
            {
                char maxChar=Func1(sources[i]);
                char test=UsingLinq(sources[i]);
                Console.WriteLine($"{sources[i]} => {maxChar} = {test==maxChar}");

            }

            for(int i=0;i<sources.Length;i++)
            {
                char maxChar=Func2(sources[i]);
                char test=UsingLinq(sources[i]);
                Console.WriteLine($"{sources[i]} => {maxChar} = {test==maxChar}");

            }
            for(int i=0;i<sources.Length;i++)
            {
                Console.WriteLine($"\n{sources[i]}");
                Func3(sources[i]);
                
            }
        }

        /*
        Print all highest occurence characters
         */
        public void Func3(string str)
        {
            int[] allChars=new int[256];
            for(int i=0;i<allChars.Length;i++)
            {
                allChars[i]=0;
            }

            int maxOccur=0;
            for(int i=0;i<str.Length;i++)
            {
                int ascValue=str[i];
                allChars[ascValue]++;
                maxOccur=Math.Max(allChars[ascValue],maxOccur);
            }

            for(int i=0;i<allChars.Length;i++)
            {
                if(maxOccur==allChars[i])
                {
                    Console.Write($"{(char)i}  ");
                }
            }

        }

        //for ascii character and buffer
        public char Func2(string str)
        {
            int[] allChars=new int[256];
            for(int i=0;i<allChars.Length;i++)
            {
                allChars[i]=0;
            }

            int maxOccur=0;
            for(int i=0;i<str.Length;i++)
            {
                int ascValue=str[i];
                allChars[ascValue]++;
                maxOccur=Math.Max(allChars[ascValue],maxOccur);
            }

            char maxChar=' ';
            int lastMaxOccur=0;
            for(int i=0;i<allChars.Length;i++)
            {
                if(lastMaxOccur<allChars[i])
                {
                    maxChar=(char)i;
                    lastMaxOccur=allChars[i];
                }
            }

            return maxChar;
        }

        ///Go through all char and compare with the upcoming ones.
        public char Func1(string str)
        {
            // return str.GroupBy(m=>m).OrderByDescending(m=>m.Count()).First().First();
            int maxOccurence=0;
            char maxChar=' ';
            for(int i=0;i<str.Length;i++)
            {
                int found=0;
                for(int j=i;j<str.Length;j++)
                {
                    if(str[i]==str[j])
                    {
                        found++;
                    }
                    
                }
                if(found>maxOccurence)
                {
                    maxChar=str[i];
                    maxOccurence=found;
                }
            }

            return maxChar;
        }

        public char UsingLinq(string str)
        {
            return str.GroupBy(m=>m).OrderByDescending(m=>m.Count()).First().First();
        }
    }
}