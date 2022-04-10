using System;
using labweek4.Classes;
// MMU ID 21432516
// Murtatha Hussein
namespace labweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(3);
            root.Left = new Node(1);
            root.Right = new Node(2);
            root.Right.Left = new Node(5);
            root.Right.Right = new Node(6);
            root.Left.Left = new Node(4);

            BinTree tree = new BinTree(root);
            string buffer = "";
            tree.InOrder(ref buffer);

            Console.WriteLine("In order Result : " + buffer);

           
            
            tree.Preorder(ref buffer);
            Console.WriteLine("preorder result are: "  + buffer);






            tree.Postorder(ref buffer);
            Console.WriteLine("Postbuffer result are : " + buffer);



            Console.WriteLine("Count:  "+ tree.Count());


            Console.ReadKey() ;
        }
    }
}
