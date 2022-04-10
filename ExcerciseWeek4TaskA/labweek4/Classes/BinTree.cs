using System;
using System.Collections.Generic;
using System.Text;

namespace labweek4.Classes
{
    class BinTree
    {



        // that is the root of the tree

        Node root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node node)
        //creates a tree with node as the root
        {
            root = node;

        }


        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node tree, ref string buffer)
        {
            if (tree != null)
            {
                // call InOrder on left subtree
                inOrder(tree.Left, ref buffer);

                // read the data stored in the node and add it into the 			string buffer
                buffer += tree.Data.ToString() + ",";

                // call InOrder on right subtree
                inOrder(tree.Right, ref buffer);
            }


            /* Given a binary tree, print
       its nodes according to the
       "bottom-up" postorder traversal. */


        }

        public void Preorder(ref string buffer)
        {
            preorder(root, ref buffer);
        }

        private void preorder(Node tree, ref string buffer)
        {
            if (tree != null)
            {


                // read the data stored in the node and add it into the 			string buffer
                buffer += tree.Data.ToString() + ",";

                // call InOrder on left subtree
                preorder(tree.Left, ref buffer);



                // call InOrder on right subtree
                preorder(tree.Right, ref buffer);
            }

        }




        public void Postorder(ref string buffer)
        {
            postorder(root, ref buffer);
        }

        private void postorder(Node tree, ref string postbuffer)
        {
            if (tree != null)
            {
                // call InOrder on left subtree
                postorder(tree.Left, ref postbuffer);


                // call InOrder on right subtree
                postorder(tree.Right, ref postbuffer);

                // read the data stored in the node and add it into the 			string buffer
                postbuffer += tree.Data.ToString() + ",";

            }
        }

        public int Count()
        {
            return count(root);
        }



        private int count(Node tree)
        {
            if (tree != null)
            {
                return 1 + count(tree.Left) + count(tree.Right);
            }
            else
            {
                return 0;

            }

        }




    }
}







