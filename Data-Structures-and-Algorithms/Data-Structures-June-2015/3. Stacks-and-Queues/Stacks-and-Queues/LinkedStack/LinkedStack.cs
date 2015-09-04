using System;
using System.Collections.Generic;

namespace LinkedStack
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        
        public int Count { get; private set; }

        public void Push(T element) 
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            this.Count--;
            var node = this.firstNode.Value;
            this.firstNode = this.firstNode.NextNode;
            return node;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = this.firstNode.Value;
                this.firstNode = this.firstNode.NextNode;
            }

            return arr;
        }
        
        private class Node<T>
        {   
            public Node<T> NextNode { get; set; }
            
            public T Value { get; private set; }
            
            public Node(T value, Node<T> nextNode = null) 
            {
                this.Value = value;
                this.NextNode = nextNode;
            }
        }
    }
}