namespace _02.Data
{
    using _02.Data.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Data : IRepository
    {
        private List<IEntity> queue;
        public int Size => queue.Count;

        public Data()
        {
            queue = new List<IEntity>();
        }

        public void Add(IEntity entity)
        {
            queue.Add(entity);
            Heapify(queue.Count - 1);
        }

        private void Heapify(int index)
        {
            int parentIndex = (index - 1) / 2;

            if (parentIndex == 0)
            {
                return;
            }

            if (queue[index].CompareTo(queue[parentIndex]) > 0)
            {
                IEntity temp = queue[index];
                queue[index] = queue[parentIndex];
                queue[parentIndex] = temp;

                Heapify(parentIndex);
            }
        }

        private void HeapifyDown(int index)
        {
            int leftIndexChild = 2 * index + 1;
            int rightIndexChild = 2 * index + 2;
            int maxIndexChild = leftIndexChild;

            if (leftIndexChild >= queue.Count)
            {
                return;
            }

            if (rightIndexChild < queue.Count &&
                queue[leftIndexChild].CompareTo(queue[rightIndexChild]) < 0)
            {
                maxIndexChild = rightIndexChild;
            }

            if (queue[index].CompareTo(queue[maxIndexChild]) < 0)
            {
                IEntity temp = queue[index];
                queue[index] = queue[maxIndexChild];
                queue[maxIndexChild] = temp;

                HeapifyDown(maxIndexChild);
            }
        }

        public IRepository Copy()
        {
            return (IRepository)this;
        }

        public IEntity DequeueMostRecent()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Operation on empty Data");
            }

            if (queue.Count == 1)
            {
                IEntity mostRecent = queue[0];
                queue.RemoveAt(0);

                return mostRecent;
            }

            IEntity temp = queue[0];
            queue[0] = queue[queue.Count - 1];
            queue[queue.Count - 1] = temp;
            queue.RemoveAt(queue.Count - 1);

            HeapifyDown(0);

            return temp;
        }

        public List<IEntity> GetAll()
        {
            return new List<IEntity>(queue);
        }

        public List<IEntity> GetAllByType(string type)
        {
            List<IEntity> result = new List<IEntity>();

            result = queue.Where(e => e.GetType().Name == type).ToList();

            //for (int i = 0; i < queue.Count; i++)
            //{
            //    if (queue[i].Status.ToString() == type)
            //    {
            //        result.Add(queue[i]);
            //    }
            //}

            if (result.Count == 0)
            {
                throw new InvalidOperationException("Operation on empty Data");
            }

            return result;
        }

        public IEntity GetById(int id)
        {
            for (int i = 0; i < queue.Count; i++)
            {
                if (queue[i].Id == id)
                {
                    return queue[i];
                }
            }

            return null;
        }

        public List<IEntity> GetByParentId(int parentId)
        {
            //List<IEntity> result = new List<IEntity>();
            //int index = -1;

            //for (int i = 1; i < queue.Count; i++)
            //{
            //    index = (i - 1) / 2;

            //    if (index == parentId)
            //    {
            //        result.Add(queue[i]);
            //    }
            //}

            //return result;

            return queue.FindAll(x => x.ParentId == parentId);
        }

        public IEntity PeekMostRecent()
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Operation on empty Data");
            }

            return queue[0];
        }
    }
}
