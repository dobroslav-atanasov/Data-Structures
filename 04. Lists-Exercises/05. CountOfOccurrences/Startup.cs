namespace _05._CountOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (!dict.ContainsKey(number))
                {
                    dict[number] = 0;
                }
                dict[number]++;
            }

            foreach (KeyValuePair<int, int> num in dict.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value} times");
            }
        }
    }
}