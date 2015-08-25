using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfOccurences
{
    class CountOfOccurences
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

            var g = numbers.GroupBy(i => i);

            foreach (var grp in g)
            {
                Console.WriteLine("{0} -> {1} times", grp.Key, grp.Count());
            }
        }
    }
}