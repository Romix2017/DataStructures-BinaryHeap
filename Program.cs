using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }

            timer.Start();
            var heap = new HeapClass(startItems);
            timer.Stop();

            Console.WriteLine("Fitst initialization of 1000 items " + timer.Elapsed);

            timer.Restart();
            for (int i = 0; i < 100; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }

            timer.Stop();
            Console.WriteLine("Add extra 1000 items " + timer.Elapsed);

            timer.Restart();

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Writing of 2000 on the screen " + timer.Elapsed);
            Console.ReadLine();
        }
    }
}
