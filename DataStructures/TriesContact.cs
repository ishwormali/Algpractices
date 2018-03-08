using System;
// using System.Collections;

namespace DataStructures
{
    public class TriesContact : IAlgorithm
    {
        private Node root=new Node();
        private Node[] children=new Node[26];
        public void Run()
        {
            string[] inputs={"add car","add card","add cart","add carting","find ca","add dart","add darty","add dary","add dairy","add damn","find dar"};

            int n = 11;//Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < n; a0++){
                string[] tokens_op =inputs[a0].Split(' ');// Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];
                switch (op)
                {
                    case "add":
                        root.Add(contact,0);    
                        break;
                    case "find":
                        int count=root.Find(contact,0);
                        Console.WriteLine(count);
                        break;
                    default:
                        throw new InvalidOperationException($"Operation {op} is not defined");
                        
                }
            }
        }

        public class Node
        {
            int count=0;
            private Node[] children=new Node[26];

            public void Add(string contact, int idx)
            {
                count++;
                if(idx>=contact.Length||string.IsNullOrWhiteSpace(contact))
                {
                    return;
                }
                
                int charCode=CharCode(contact[idx]);
                Node existingNode=children[charCode];
                if(existingNode==null)
                {
                    existingNode=new Node();
                    
                    children[charCode]=existingNode;
                }

                existingNode.Add(contact,++idx);
            }

            public int Find(string contact,int idx)
            {
                if(idx>=contact.Length || string.IsNullOrWhiteSpace(contact))
                {
                    return count;
                }

                int charCode=CharCode(contact[idx]);
                Node existingNode=children[charCode];
                if(existingNode==null)
                {
                    return 0;
                }
                else
                {
                    return existingNode.Find(contact,++idx);
                }
            }

            private int CharCode(char c)
            {
                return (int)c-(int)'a';
            }
        }
    }
}