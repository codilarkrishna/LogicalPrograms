using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AbstractMethod.InterviewPrograms
{
    class SampleMultithreading
    {
        static void Main23(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInfo1));
            Thread t2 = new Thread(new ThreadStart(PrintInfo2));
            t1.Start();
            t2.Start();
            Console.WriteLine("Main Thread Execution Completed");
            Console.ReadLine();
        }
        static void PrintInfo1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("i value: {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First Child Thread Execution Completed");
        }
        static void PrintInfo2()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second Child Thread Execution Completed");
        }
    }
}
