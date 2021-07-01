using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Tuple<T, V>
    {
        public T FirstElement { get; private set; }
        public V SecondElement { get; private set; }

        public Tuple(T firstElement, V secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
