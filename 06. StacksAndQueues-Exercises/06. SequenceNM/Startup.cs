namespace _06._SequenceNM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int startNumber = numbers[0];
            int endNumber = numbers[1];

            if (endNumber < startNumber)
            {
                return;
            }

            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(new Cell(startNumber));

            while (queue.Count > 0)
            {
                Cell currentCell = queue.Dequeue();

                if (currentCell.Value == endNumber)
                {
                    Print(currentCell);
                    return;
                }
                else if(currentCell.Value > endNumber)
                {
                    continue;
                }
                
                queue.Enqueue(new Cell(currentCell.Value + 1, currentCell));
                queue.Enqueue(new Cell(currentCell.Value + 2, currentCell));
                queue.Enqueue(new Cell(currentCell.Value * 2, currentCell));
            }
        }

        private static void Print(Cell currentCell)
        {
            List<int> numbers = new List<int>();
            Cell start = currentCell;
            while (start != null)
            {
                numbers.Add(start.Value);
                start = start.Previous;
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" -> ", numbers));
        }
    }
}