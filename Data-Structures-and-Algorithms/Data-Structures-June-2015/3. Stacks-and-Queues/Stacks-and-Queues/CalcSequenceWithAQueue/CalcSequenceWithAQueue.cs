using System;
using System.Collections.Generic;
using System.Linq;

namespace CalcSequenceWithAQueue
{
    class CalcSequenceWithAQueue
    {
        static void Main()
        {
            Console.Write("n: ");
            var n = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(n);

            int currentElement = 0;

            for (int i = 0; i < 16; i++)
            {
                sequence.Enqueue(sequence.ElementAt(currentElement) + 1);
                sequence.Enqueue(sequence.ElementAt(currentElement) * 2 + 1);
                sequence.Enqueue(sequence.ElementAt(currentElement) + 2);

                currentElement += 1;
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}