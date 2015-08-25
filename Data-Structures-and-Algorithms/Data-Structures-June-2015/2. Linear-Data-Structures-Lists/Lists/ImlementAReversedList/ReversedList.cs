using System;
using System.Collections;
using System.Collections.Generic;

namespace ImlementAReversedList
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] array;

        public ReversedList(int capacity = 4)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
        }

        public int Count { get; private set; }
        public int Capacity { get; private set; }
        
        public void Add(T item)
        {
            if (this.Count >= this.Capacity)
            {
                this.DoubleCapacity();
            }

            this.array[this.Count] = item;
            this.Count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.array[index];
            }
            set
            {
                if (index < 0 || index > this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.array[index] = value;
            }
        }

        public void Remove(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (index >= this.Count)
            {
                throw new InvalidOperationException();
            }

            for (long i = this.Count - index; i < this.Count; i++)
            {
                this.array[i - 1] = this.array[i];
            }

            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0 ; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void DoubleCapacity()
        {
            this.Capacity *= 2;
            var tempArr = new T[this.Capacity];
            Array.Copy(this.array, tempArr, this.Count);
            this.array = tempArr;
        }
    }

    public class Example
    {
        static void Main()
        {
            var list = new ReversedList<int>() { 1, 2, 3, 4 };

            list.Add(5);
            list.Add(6);
            list.Add(7);

            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);

            list.Remove(4);

            Console.WriteLine(string.Join(", ", list));

        }
    }
}