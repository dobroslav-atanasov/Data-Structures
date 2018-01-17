using System;

public class Startup
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.AddFirst(1);
        list.AddLast(2);

        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}