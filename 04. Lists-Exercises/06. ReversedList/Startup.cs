using System;

public class Startup
{
    public static void Main()
    {
        ReversedList<int> reversedList = new ReversedList<int>();

        reversedList.Add(1);
        reversedList.Add(2);
        reversedList.Add(3);
        reversedList.Add(4);
        reversedList.Add(5);
        reversedList.Add(6);
        reversedList.Add(7);
        reversedList.Add(8);

        reversedList.RemoveAt(4);

        foreach (int num in reversedList)
        {
            Console.WriteLine(num);
        }
    }
}