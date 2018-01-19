using System;

public class LinkedStack<T>
{
    public Node Head { get; set; }

    public int Count { get; private set; }

    public void Push(T element)
    {
        if (this.Count == 0)
        {
            this.Head = new Node(element);
            this.Count++;
        }
        else
        {
            Node node = new Node(element);
            node.Next = this.Head;
            this.Head = node;
            this.Count++;
        }
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        else if (this.Count == 1)
        {
            T element = this.Head.Value;
            this.Head = null;
            this.Count--;
            return element;
        }
        else
        {
            T element = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;
            return element;
        }
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];
        Node node = this.Head;
        int i = 0;
        while (node != null)
        {
            array[i] = node.Value;
            i++;
            node = node.Next;
        }
        return array;
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