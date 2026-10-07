using System;
using System.Threading;

namespace ThreadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a thread-ek számát (1-10): ");

            int number;

            if(!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 10)
            {
                Console.WriteLine("Hibás bemenet. Kérem, adjon meg egy számot 1 és 10 között.");
                return;
            }

            Thread[] threads = new Thread[number];

            for(int i=0;i< number; i++)
            {
                int threadNumber = i + 1;
                threads[i] = new Thread(() => Run(threadNumber));
                threads[i].Start();
            }

            for (int i = 0; i < number; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("Minden thread befejezodott.");
            Console.ReadKey();
        }

        static void Run(int id)
        {
            Console.WriteLine("Thread " + id + " has started.");

            Thread.Sleep(10000);

            Console.WriteLine("Thread " + id + " has finished Running.");
        }
    }

}
