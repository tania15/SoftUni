﻿using System.Collections.Generic;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly List<T> elements;
        public int Count { 
            get 
            {
                return elements.Count;
            }
        }

        public Box()
        {
            elements = new List<T>();
        }
        public void Add(T element)
        {
            elements.Add(element);            
        }

        public T Remove()
        {
            T value = elements.LastOrDefault();
            elements.RemoveAt(elements.Count - 1);
            return value;
        }
    }
}
