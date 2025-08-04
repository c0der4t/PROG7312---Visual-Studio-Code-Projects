using System;

namespace prjPriorityQueue {
    class Program
    {
        static void Main(string[] args)
        {
            queue e = new queue();
            e.enqueue(10, 20);
            e.enqueue(20, 60);
            e.enqueue(30, 40);
            e.enqueue(45, 50);
            e.enqueue(1, 60);

            int iPos = e.peek();
            Console.WriteLine(iPos);
            Console.WriteLine(e.pr[iPos].value);
        }
    }
}