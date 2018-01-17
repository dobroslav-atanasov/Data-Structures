using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    public Node Head { get; private set; }

    public Node Tail { get; private set; }

    public int Count { get; private set; }

    public void AddFirst(T item)
    {
        Node node = new Node(item);

        if (this.Count == 0)
        {
            this.Head = node;
            this.Tail = node;
        }
        else
        {
            node.Next = this.Head;
            this.Head = node;
        }
        this.Count++;
    }

    public void AddLast(T item)
    {
        Node node = new Node(item);

        if (this.Count == 0)
        {
            this.Head = node;
            this.Tail = node;
        }
        else
        {
            this.Tail.Next = node;
            this.Tail = node;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.Head.Value;
        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head.Next;
        }
        this.Count--;
        return element;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.Tail.Value;
        if (this.Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            Node parent = this.Head;
            while (parent.Next != this.Tail)
            {
                parent = parent.Next;
            }
            parent.Next = null;
            this.Tail = parent;
        }
        this.Count--;
        return element;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node node = this.Head;
        while (node != null)
        {
            yield return node.Value;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Node Next { get; set; }
    }
}
