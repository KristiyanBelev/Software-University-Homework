using System;
using System.Collections.Generic;
namespace SortWords
{
    class SortWords
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            var words = new List<string>();
            words.AddRange(values);
            words.Sort();

            Console.WriteLine(String.Join(" ", words));
        }
    }
}