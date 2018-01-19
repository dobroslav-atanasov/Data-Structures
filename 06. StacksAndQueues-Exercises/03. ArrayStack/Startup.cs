using System;

public class Startup
{
    public static void Main()
    {
        ArrayStack<int> arrayStack = new ArrayStack<int>();
        
        arrayStack.Push(1);
        arrayStack.Push(2);
        arrayStack.Push(3);
        arrayStack.Push(4);
        arrayStack.Push(5);

        int element = arrayStack.Pop();
        Console.WriteLine(element);
        Console.WriteLine(arrayStack.Count);

        int[] array = arrayStack.ToArray();
        Console.WriteLine(string.Join(", ", array));
    }
}