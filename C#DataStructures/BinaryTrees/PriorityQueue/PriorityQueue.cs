using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueue
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> priorityQueue;

        public int Size { get { return priorityQueue.Count; } }

        public PriorityQueue()
        {
            priorityQueue = new List<T>();
        }

        public T Peek()
        {
            return priorityQueue[0];
        }

        public void Add(T element)
        {
            priorityQueue.Add(element);
            Heapify(priorityQueue.Count - 1);
        }

        public T Dequeue()
        {
            // save top
            // swap top with last
            // heapify down

            T top = priorityQueue[0];
            priorityQueue[0] = priorityQueue[priorityQueue.Count - 1];
            priorityQueue.RemoveAt(priorityQueue.Count - 1);

            HeapifyDown(0);

            return top;
        }
        private void Heapify(int index)
        {
            if (index == 0)
            {
                return;
            }

            int parentIndex = (index - 1) / 2;

            if (priorityQueue[index].CompareTo(priorityQueue[parentIndex]) > 0)
            {
                T temp = priorityQueue[index];
                priorityQueue[index] = priorityQueue[parentIndex];
                priorityQueue[parentIndex] = temp;

                Heapify(parentIndex);
            }
        }

        private void HeapifyDown(int index)
        {
            int leftChildIndex = index * 2 + 1;
            int rightChildIndex = index * 2 + 2;
            int maxChildIndex = leftChildIndex;

            if (leftChildIndex >= priorityQueue.Count)
            {
                return;
            }

            if (rightChildIndex < priorityQueue.Count && 
                priorityQueue[leftChildIndex].CompareTo(priorityQueue[rightChildIndex]) < 0)
            {
                maxChildIndex = rightChildIndex;
            }

            if (priorityQueue[index].CompareTo(priorityQueue[maxChildIndex]) < 0)
            {
                T temp = priorityQueue[index];
                priorityQueue[index] = priorityQueue[maxChildIndex];
                priorityQueue[maxChildIndex] = temp;

                HeapifyDown(maxChildIndex);
            }
        }        
    }
}
