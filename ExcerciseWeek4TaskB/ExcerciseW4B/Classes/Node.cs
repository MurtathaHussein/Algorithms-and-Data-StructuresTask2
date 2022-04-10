using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseW4B.Classes
{
     class Node
    {
     
        
            private string data; // data stored are string
            public Node Left, Right;

            public Node(string item)
            {
                data = item;
                Left = null;
                Right = null;
            }
            public string Data
            {
                set { data = value; }
                get { return data; }
            }
       
    
        }

 }

