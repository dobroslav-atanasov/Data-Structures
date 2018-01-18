namespace _04._RemoveOddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}