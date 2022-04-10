using System;
using System.Diagnostics;
using ExcerciseW4B.Classes;


namespace ExcerciseW4B.Classes
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            Node root = new Node("ab");
            root.Left = new Node("de");
            root.Right = new Node("bh");
            root.Right.Left = new Node("vv");
            root.Left.Left = new Node("re");
            root.Left.Left.Left = new Node("ut");
            root.Right.Right = new Node("af");
            root.Right.Right.Right = new Node("wa");

            BinTree mytree = new BinTree(root);








            Console.WriteLine("Number of nodes is " + mytree.Counting());


        }





















    }






}

