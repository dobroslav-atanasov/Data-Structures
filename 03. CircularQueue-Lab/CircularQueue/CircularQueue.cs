using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    private T[] array;
    private int startIndex = 0;
    private int endIndex = 0;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.array = new T[capacity];
    }

    public void Enqueue(T element)
    {
        if (this.Count >= this.array.Length)
        {
            this.Resize();
        }
        this.array[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.array.Length;
        this.Count++;
    }

    private void Resize()
    {
        T[] newArray = new T[this.array.Length * 2];
        this.CopyAllElements(newArray);
        this.array = newArray;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }

    private void CopyAllElements(T[] newArray)
    {
        int sourceIndex = this.startIndex;
        int destinationIndex = 0;
        for (int i = 0; i < this.Count; i++)
        {
            newArray[destinationIndex] = this.array[sourceIndex];
            sourceIndex = (sourceIndex + 1) % this.array.Length;
            destinationIndex++;
        }
    }
    
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        T element = this.array[this.startIndex];
        this.startIndex = (this.startIndex + 1) % this.array.Length;
        this.Count--;
        return element;
    }

    public T[] ToArray()
    {
        T[] newArray = new T[this.Count];
        this.CopyAllElements(newArray);
        return newArray;
    }
}