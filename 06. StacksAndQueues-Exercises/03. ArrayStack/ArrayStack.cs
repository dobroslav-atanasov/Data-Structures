using System;

public class ArrayStack<T>
{
    private const int InitialCapacity = 16;
    private T[] array;

    public ArrayStack(int capacity = InitialCapacity)
    {
        this.array = new T[capacity];
        this.Count = 0;
    }

    public int Count { get; private set; }

    public void Push(T item)
    {
        if (this.Count == this.array.Length)
        {
            Array.Resize(ref this.array, this.array.Length * 2);
        }

        this.array[this.Count] = item;
        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }
        
        T element = this.array[this.Count - 1];
        this.array[this.Count - 1] = default(T);
        this.Count--;
        return element;
    }

    public T[] ToArray()
    {
        T[] newArray = new T[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            newArray[newArray.Length - i - 1] = this.array[i];
        }
        return newArray;
    }
}