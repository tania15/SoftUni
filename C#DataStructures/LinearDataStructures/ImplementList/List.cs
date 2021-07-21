using System;

namespace ImplementList
{
    public class List<T>
    {
        private T[] array;
        private int index = 0;

        public List(int initialCapacity = 4)
        {
            array = new T[initialCapacity];
        }

        public int Count 
        { 
            get 
            { 
                return index; 
            }
            set
            {
                index = value;
            }
        }
        //public int InternalArrayCount { get { return array.Length; } }

        // indexer
        public T this[int i]
        {
            get
            {
                ValidateIndex(index);
                return array[i];
            }
            set
            {
                ValidateIndex(index);
                array[i] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }

        public void Add(T element)
        {
            if (Count == array.Length)
            {
                array = DoubleArraySize();
            }

            array[Count] = element;
            Count++;
        }

        public void Insert(T element, int index)
        {
            ValidateIndex(index);

            if (Count == array.Length)
            {
                array = DoubleArraySize();
            }

            T[] newArray = new T[Count + 1];
            Array.Copy(array, newArray, index + 1);

            for (int i = Count - 1; i >= index; i--)
            {
                newArray[i + 1] = array[i];
            }

            newArray[index] = element;
            Count++;
            array = newArray;
        }

        private T[] DoubleArraySize()
        {
            T[] newArray = new T[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;
            //array[this.index - 1] = default;            
        }

        public bool RemoveElement(T element)
        {
            int indexOfElement = int.MinValue;

            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(element))
                {
                    indexOfElement = i;
                    break;
                }
            }

            if (indexOfElement >= 0)
            {
                RemoveAt(indexOfElement);
                return true;
            }

            return false;
        }

        private T[] Shrink()
        {
            T[] newArray = new T[array.Length / 2];
            Array.Copy(array, newArray, newArray.Length);

            return newArray;
        }
    }
}
