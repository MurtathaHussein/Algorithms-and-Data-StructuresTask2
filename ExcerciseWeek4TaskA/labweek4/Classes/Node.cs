using System;
using System.Collections.Generic;
using System.Text;

namespace labweek4.Classes
{
    class Node
    {


        private int data;

        public Node Left, Right;
        public Node(int item)
        {
            this.data = item;
            Left = null;
                Right = null;
        }
        public int Data
        {
            set { data = value; }
            get { return data; }
        }

    }
}
