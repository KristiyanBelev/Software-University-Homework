using System;
using System.Collections;
using System.Collections.Generic;

namespace ImplementALinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode<T>(item);
            }
            else
            {
                var newTail = new ListNode<T>(item);
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public void Remove(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            else
            {
                ListNode<T> temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.NextNode;
                }
                temp.NextNode = temp.NextNode.NextNode;
                this.Count--;
            }
        }

        public int FirstIndexOf(T item)
        {
            var currentNode = this.head;
            var itemNode = new ListNode<T>(item);

            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(itemNode.Value))
                {
                    return index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }

            return -1;
        }

        public int LastIndexOf(T item)
        {
            var currentNode = this.head;
            var itemNode = new ListNode<T>(item);

            var lastIndex = -1;

            int index = 0;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(itemNode.Value))
                {
                    lastIndex = index;
                }
                currentNode = currentNode.NextNode;
                index++;
            }

            return lastIndex;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class Example
    {
        static void Main()
        {

            var list = new LinkedList<int>();

            list.Add(5);
            list.Add(21);
            list.Add(2);
            list.Add(5);
            list.Add(7);
            list.Add(5);
            list.Add(21);

            Console.WriteLine(list.FirstIndexOf(21));
            Console.WriteLine(list.LastIndexOf(22));
            Console.WriteLine("Count: {0}",list.Count);
            Console.WriteLine(string.Join(", ", list));
            list.Remove(2);
            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}