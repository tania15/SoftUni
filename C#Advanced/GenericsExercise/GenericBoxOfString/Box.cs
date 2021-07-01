using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;

namespace GenericBoxOfString
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public List<T> Elements { get; }
        public T Element { get; }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }        

        public void Swap(List<T> list, int index1, int index2)
        {            
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var e in Elements)
            {
                sb.AppendLine($"{e.GetType()}: {e}");
            }

            return sb.ToString().TrimEnd();
        }

        public int CompareTo(T other) => Element.CompareTo(other);
        
        public int CountIfGreaterElements<T>(List<T> list, T readLine) where T : IComparable
        {
            int count = list.Count(w => w.CompareTo(readLine) > 0);
            return count;
        }
    }
}
