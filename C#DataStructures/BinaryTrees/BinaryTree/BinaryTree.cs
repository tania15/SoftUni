using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree(Node<T> root)
        {
            Root = root;
        }

        public string DFS(Node<T> node)
        {
            string result = $"{node.Value}\n";

            if (node.LeftChild != null)
            {
                result += DFS(node.LeftChild);
            }
            
            if(node.RightChild != null)
            {
                result += DFS(node.RightChild);
            }

            return result;
        }

        public string DFSInOrder(Node<T> node, int indent)
        {
            string result = "";

            if (node.LeftChild != null)
            {
                result += DFSInOrder(node.LeftChild, indent + 3);
            }

            result += $"{new string(' ', indent)}{node.Value}\n";

            if (node.RightChild != null)
            {
                result += DFSInOrder(node.RightChild, indent + 3);
            }

            return result;
        }

        public string DFSPostOrder(Node<T> node, int indent)
        {
            string result = "";

            if (node.LeftChild != null)
            {
                result += DFSPostOrder(node.LeftChild, indent + 3);
            }            

            if (node.RightChild != null)
            {
                result += DFSPostOrder(node.RightChild, indent + 3);
            }

            result += $"{new string(' ', indent)}{node.Value}\n";

            return result;
        }
    }
}
