using System;
namespace LinkedQueue
{
    class Program
    {
        static void Main()
        {
            var queue = new LinkedQueue<int>();
            queue.Enqueue(2);
            queue.Enqueue(7);
            queue.Enqueue(-4);
            queue.Enqueue(5);
            queue.Enqueue(13);

            var arr = queue.ToArray();

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}