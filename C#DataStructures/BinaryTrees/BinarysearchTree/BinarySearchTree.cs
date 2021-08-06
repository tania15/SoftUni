﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree(Node<T> root = null)
        {
            Root = root;
        }

        public void Insert(Node<T> node, T value)
        {
            // check if value is bigger or smaller than root
            // go left or right accordingly
            // repeat for child element
            // find the first null child element and put the new node there

            if (node == null)
            {
                node = new Node<T>(value);
                Root = node;
                return;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new Node<T>(value);
                    return;
                }

                Insert(node.LeftChild, value);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new Node<T>(value);
                    return;
                }

                Insert(node.RightChild, value);
            }
        }

        public bool Contains(T value, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return true;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return false || Contains(value, node.LeftChild);
            }
            else
            {
                return false || Contains(value, node.RightChild);
            }
        }

        public Node<T> Search(T value, Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Search(value, node.LeftChild);
            }
            else
            {
                return Search(value, node.RightChild);
            }
        }
    }
}
