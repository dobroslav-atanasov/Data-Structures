using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private Node<T> head;
    private Node<T> tail;

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        if (this.Count == 0)
        {
            this.head = this.tail = new Node<T>(element);
        }
        else
        {
            Node<T> node = new Node<T>(element);
            node.Next = this.head;
            this.head.Previos = node;
            this.head = node;
        }
        this.Count++;
    }

    public void AddLast(T element)
    {
        if (this.Count == 0)
        {
            this.head = this.tail = new Node<T>(element);
        }
        else
        {
            Node<T> node = new Node<T>(element);
            node.Previos = this.tail;
            this.tail.Next = node;
            this.tail = node;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        Node<T> element = this.head;
        this.head = this.head.Next;
        if (this.head != null)
        {
            this.head.Previos = null;
        }
        else
        {
            this.tail = null;
        }

        this.Count--;
        return element.Value;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        Node<T> element = this.tail;
        this.tail = this.tail.Previos;
        if (this.tail != null)
        {
            this.tail.Next = null;
        }
        else
        {
            this.head = null;
        }

        this.Count--;
        return element.Value;
    }

    public void ForEach(Action<T> action)
    {
        Node<T> node = this.head;
        while (node != null)
        {
            action(node.Value);
            node = node.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> node = this.head;
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

    public T[] ToArray()
    {
        T[] array = new T[this.Count];
        Node<T> node = this.head;
        for (int i = 0; i < this.Count; i++)
        {
            array[i] = node.Value;
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

        public T Value { get; private set; }

        public Node<T> Next { get; set; }

        public Node<T> Previos { get; set; }
    }
}