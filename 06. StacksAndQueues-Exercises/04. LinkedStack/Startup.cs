using System;

public class Startup
{
    public static void Main()
    {
        LinkedStack<int> linkedStack = new LinkedStack<int>();

        linkedStack.Push(1);
        linkedStack.Push(2);
        linkedStack.Push(3);

        linkedStack.Pop();

        Console.WriteLine(linkedStack.Count);

        int[] array = linkedStack.ToArray();
        Console.WriteLine(string.Join(" ", array));
    }
}