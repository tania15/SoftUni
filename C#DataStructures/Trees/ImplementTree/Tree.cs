using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementTree
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        public Tree(T value, params Node<T>[] children)
            :this(value)
        {
            foreach (var child in children)
            {
                Root.Children.Add(child);
            }
        }

        public List<T> BFS(Node<T> root)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<T> resultList = new List<T>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                resultList.Add(node.Value);

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return resultList;
        }

        //public void DFS(Node<T> node, int level)
        //{
        //    Console.Write(new string(' ', level));
        //    Console.WriteLine(node);

        //    foreach (var child in node.Children)
        //    {
        //        DFS(child, level + 3);
        //    }
        //}

        public List<T> DFS(Node<T> node, int level)
        {
            List<T> list = new List<T>();
            //list.Add(node.Value);

            foreach (var child in node.Children)
            {
                list.AddRange(DFS(child, level + 3));
            }

            list.Add(node.Value);

            return list;
        }
    }
}
