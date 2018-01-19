namespace _02._CalculateSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(number);

            List<int> numbers = new List<int>();
            numbers.Add(number);

            while (numbers.Count < 50)
            {
                int currentNumber = queue.Dequeue();
                int firstNumber = currentNumber + 1;
                int secondNumber = 2 * currentNumber + 1;
                int thirdNumber = currentNumber + 2;

                queue.Enqueue(firstNumber);
                queue.Enqueue(secondNumber);
                queue.Enqueue(thirdNumber);

                numbers.Add(firstNumber);
                numbers.Add(secondNumber);
                numbers.Add(thirdNumber);
            }
            
            Console.WriteLine(string.Join(", ", numbers.Take(50)));
        }
    }
}