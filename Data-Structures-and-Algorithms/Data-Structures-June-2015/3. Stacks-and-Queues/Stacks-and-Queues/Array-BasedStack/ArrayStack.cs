using System;
using System.Collections.Generic;

namespace ArrayBasedStack
{
    public class ArrayStack<T>
    {
        private T[] elements;
        
        public int Count { get; private set; }
        
        private const int InitialCapacity = 16;
        
        public ArrayStack(int capacity = InitialCapacity) 
        {
            this.elements = new T[capacity];
        }

        public void Push(T element) 
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }
        
        public T Pop() 
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            this.Count--;
            var element = this.elements[this.Count];
            this.elements[this.Count] = default(T);
            return element;
        }
        
        public T[] ToArray() 
        {
            T[] arr = new T[this.Count];

            for (int i = this.Count - 1, j = 0; i >= 0; i--, j++)
            {
                arr[j] = this.elements[i];
            }

            return arr;
        }
        
        private void Grow() 
        {
            T[] newElements = new T[2 * this.Count];
            Array.Copy(this.elements, newElements, this.Count);
            this.elements = newElements;
        }
    }
}