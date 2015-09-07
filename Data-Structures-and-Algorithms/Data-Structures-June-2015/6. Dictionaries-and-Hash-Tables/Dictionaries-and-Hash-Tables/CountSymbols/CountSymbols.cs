using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = input
                .GroupBy(c => c)
                .OrderBy(c => c.Key)
                .ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (var ch in dict)
            {
                Console.WriteLine("{0}: {1} time/s", ch.Key, ch.Value);
            }
        }
    }
}