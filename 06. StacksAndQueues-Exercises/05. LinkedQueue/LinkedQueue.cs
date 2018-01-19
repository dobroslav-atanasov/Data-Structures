using System;

public class LinkedQueue<T>
{
    private Node<T> head;
    private Node<T> tail;

    public int Count { get; set; }

    public void Enqueue(T element)
    {
        if (this.Count == 0)
        {
            this.head = this.tail = new Node<T>(element);
        }
        else
        {
            Node<T> node = new Node<T>(element);
            node.Previous = this.tail;
            this.tail.Next = node;
            this.tail = node;
        }
        this.Count++;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        else if (this.Count == 1)
        {
            T element = this.head.Value;
            this.head = this.tail = null;
            this.Count--;
            return element;
        }
        else
        {
            T element = this.head.Value;
            this.head = this.head.Next;
            this.head.Previous = null;
            this.Count--;
            return element;
        }
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];
        int index = 0;
        Node<T> node = this.head;
        while (node != null)
        {
            array[index] = node.Value;
            index++;
            node = node.Next;
        }
        return array;
    }

    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Previous { get; set; }
    }
}