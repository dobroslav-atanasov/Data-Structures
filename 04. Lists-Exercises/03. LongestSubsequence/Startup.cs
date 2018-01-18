namespace _03._LongestSubsequence
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

            int longest = 1;
            int count = 1;
            int index = 0;
            int startIndex = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                    index = i + 1;
                }

                if (count > longest)
                {
                    longest = count;
                    startIndex = index;
                }
            }

            for (int i = startIndex; i < startIndex + longest; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}