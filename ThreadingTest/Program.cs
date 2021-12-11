using System;
using System.Threading;

namespace ThreadingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Run);
            thread.Start();
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }

        static void Run()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Run!");
            }
        }
    }
}
