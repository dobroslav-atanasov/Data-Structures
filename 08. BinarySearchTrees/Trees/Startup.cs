using System;

public class Startup
{
    public static void Main()
    {
        BinarySearchTree<int> bfs = new BinarySearchTree<int>();
        bfs.Insert(5);
        bfs.Insert(3);
        bfs.Insert(7);
        bfs.Insert(2);
        bfs.Insert(10);
        bfs.Insert(10);
        bfs.Insert(14);

        foreach (int num in bfs.Range(2, 7))
        {
            Console.WriteLine(num);
        }
    }
}