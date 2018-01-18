using System;
using System.Collections;
using System.Collections.Generic;

public class ReversedList<T> : IEnumerable<T>
{
    private T[] array;

    public ReversedList()
    {
        this.array = new T[2];
    }

    public int Count { get; private set; }

    public int Capacity
    {
        get => this.array.Length;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.array.Length)
            {
                throw new InvalidOperationException("Index out of bounds!");
            }
            return this.array[this.Count - index - 1];
        }
        set
        {
            if (index < 0 || index >= this.array.Length)
            {
                throw new InvalidOperationException("Index out of bounds!");
            }
            this.array[this.Count - index - 1] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            this.Resize();
        }
        this.array[this.Count] = item;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.array.Length * 2];
        for (int i = 0; i < this.array.Length; i++)
        {
            newArray[i] = this.array[i];
        }
        this.array = newArray;
    }

    public T RemoveAt(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new InvalidOperationException("Index out of bounds!");
        }

        T element = this.array[this.Count - index - 1];
        this.array[this.Count - index - 1] = default(T);
        this.Reorder(index);
        this.Count--;

        return element;
    }

    private void Reorder(int index)
    {
        for (int i = this.Count - index - 1; i < this.Count- 1; i++)
        {
            this.array[i] = this.array[i + 1];
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count - 1; i >= 0; i--)
        {
            yield return this.array[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}