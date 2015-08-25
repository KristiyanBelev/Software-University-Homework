using System;
using System.Collections.Generic;

namespace ImplementALinkedList
{
    internal class ListNode<T>
    {
        public T Value { get; private set; }

        public ListNode<T> NextNode { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }
    }
}