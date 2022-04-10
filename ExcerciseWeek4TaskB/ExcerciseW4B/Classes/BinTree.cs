using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseW4B.Classes
{
    class BinTree
    {
    
            // that is the root of the tree

            private Node root;
            public BinTree()  //creates an empty tree
            {
                root = null;
            }
            public BinTree(Node node)
            //creates a tree with node as the root
            {
                root = node;
            }

        //Method to count
        public int Counting()
        {

            return Counting(root);

        }


        private int Counting(Node tree)

        {
            if (tree != null)
            {

                return 1+ (Counting(tree.Left) + Counting(tree.Right) );
            }
            else
                return 0;

        }



        //Height of the tree
        public int Height()
        {
            return Height(root);
        }


        private int Height(Node tree)
        {
            if (tree != null)
            {

                // idea: compare the Height of the left subtree and the height of the right subtree; get the largest of the two (using Math.Max) and add 1 which is the level of the root
                return Math.Max(Counting(tree.Left), Counting(tree.Right)) + 1;

            }
            else
            {
                return 0;
            }

        }












    }

}

