using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurences
{
    class RemoveOddOccurences
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            var numbers = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int number;
                bool IsInt = int.TryParse(values[i], out number);
                if (IsInt)
                {
                    numbers.Add(number);
                }
            }

            var g = numbers.GroupBy(i => i);

            foreach (var grp in g)
            {
                if (grp.Count() % 2 != 0)
                {
                    int count = grp.Count();
                    while (count > 0)
                    {
                        numbers.Remove(grp.Key);
                        count--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}