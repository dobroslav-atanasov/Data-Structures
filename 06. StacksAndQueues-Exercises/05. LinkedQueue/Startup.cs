using System;

public class Startup
{
    public static void Main()
    {
        LinkedQueue<int> linkedQueue = new LinkedQueue<int>();

        linkedQueue.Enqueue(1);
        linkedQueue.Enqueue(2);
        linkedQueue.Enqueue(3);
        Console.WriteLine(linkedQueue.Count);

        linkedQueue.Dequeue();
        Console.WriteLine(linkedQueue.Count);

        int[] array = linkedQueue.ToArray();
        Console.WriteLine(string.Join(" ", array));
    }
}