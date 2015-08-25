using System;
using System.Collections.Generic;

namespace SumAndAverage
{
    class SumAndAverage
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            var list = new List<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int number;
                bool isInt = int.TryParse(values[i], out number);
                if (isInt)
                {
                    list.Add(number);
                }
            }
            
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }

            var average = 0.0;
            if (list.Count != 0)
            {
                average = (double)sum / list.Count;
            }

            Console.WriteLine("Sum={0}; Average={1}", sum, average);
        }
    }
}