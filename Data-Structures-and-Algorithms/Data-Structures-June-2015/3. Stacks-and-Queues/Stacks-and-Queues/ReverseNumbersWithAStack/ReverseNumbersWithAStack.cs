using System;
using System.Collections.Generic;

namespace ReverseNumbersWithAStack
{
    class ReverseNumbersWithAStack
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            var numbers = new Stack<int>();
            for (int i = 0; i < values.Length; i++)
            {
                int number;
                bool isInt = int.TryParse(values[i], out number);
                if (isInt)
                {
                    numbers.Push(number);
                }
            }

            numbers.ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}