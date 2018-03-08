using System;

namespace DataStructures
{
    public class RemoveDuplicateChar : IAlgorithm
    {
        public void Run()
        {
            // string[,] sources=new string[,]{{"flafbeaec","flabec"},{"ABCabcCAe","ABCabce"}};
            //Do not use above multi dimensional array as the sources.Length=4;
            string[][] sources=new string[][]{new string[]{"flafbeaec","flabec"},new string[]{"ABCabcCAe","ABCabce"}};
            
            Console.WriteLine("Case sensitive");
            TestFunc(sources,FuncCaseSensite);
            
            // string[,] sources2=new string[,]{{"flafbeaec","flabec"},{"ABCabce","ABCe"}};
            string[][] sources2=new string[][]{new string[]{"flafbeaec","flabec"},new string[]{"ABCabce","ABCe"}};
            
            Console.WriteLine("Case insensitive");
            TestFunc(sources2,FuncCaseInSensite);
            
            
            
        }

        ///Removes duplicate characters without built in functions
        ///Case Sensitive
        public string FuncCaseSensite(string str)
        {

            string allExistingChars=string.Empty;
            for(int i=0;i<str.Length;i++)
            {
                char chr=str[i];
                if(allExistingChars.IndexOf(chr)<0)
                {
                    allExistingChars+=chr;

                }
            }

            return allExistingChars;
        }

        public void TestFunc(string[][] sources,Func<string,string> func)
        {
            for(int i=0;i<sources.Length;i++)
            {
                string str1=sources[i][0];
                string str2=sources[i][1];
                string result=func(str1);
                Console.WriteLine($"{str1} -> {result} = {result==str2}");

            }

        }

        ///Case Insensitive
        public string FuncCaseInSensite(string str)
        {
            string allExistingChars=string.Empty;
            string finalString=string.Empty;

            for(int i=0;i<str.Length;i++)
            {
                char chr=Char.ToLowerInvariant(str[i]);
                if(allExistingChars.IndexOf(chr)<0)
                {
                    allExistingChars+=chr;
                    finalString+=str[i];

                }
            }

            return finalString;
        }
    }
}