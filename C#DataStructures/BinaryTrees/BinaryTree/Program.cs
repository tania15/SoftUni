using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(1,
                new Node<int>(5,
                    new Node<int>(2),
                    new Node<int>(3)),
                new Node<int>(7,
                    new Node<int>(9),
                    new Node<int>(11))
                );

            BinaryTree<int> tree = new BinaryTree<int>(root);

            //Console.WriteLine(tree.DFS(root));

            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine(tree.DFSInOrder(root, 0));

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine(tree.DFSPostOrder(root, 0));
        }
    }
}
