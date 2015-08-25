using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    class LongestSubsequence
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            var numbers = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int number;
                bool isInt = int.TryParse(values[i], out number);
                if (isInt)
                {
                    numbers.Add(number);
                }
            }

            var longestSubsequence = new List<int>();

            var g = numbers.GroupBy(i => i);

            foreach (var grp in g)
            {
                if (grp.Count() > longestSubsequence.Count)
                {
                    longestSubsequence = new List<int>();
                    int count = grp.Count();
                    while (count > 0)
                    {
                        longestSubsequence.Add(grp.Key);
                        count--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }
}