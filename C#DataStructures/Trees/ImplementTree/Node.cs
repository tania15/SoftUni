﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementTree
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }

        public Node(T value)
        {
            Value = value;
            Children = new List<Node<T>>();
        }

        public Node(T value, params Node<T>[] children)
            :this(value)
        {
            foreach (var child in children)
            {
                Children.Add(child);
            }
        }
    }
}
