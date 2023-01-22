using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class SampleThreading
    {
        static void Main6(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInfo));
            t1.Start();
            t1.IsBackground = true;//for background threads
            Console.WriteLine("Main Thread Execution Completed");
            Console.ReadLine();
        }
        static void PrintInfo()
        {
            for (int i = 1; i <= 3; i++)
            {
               
                Console.WriteLine("i value: {0}", i);
               
            }
            Console.WriteLine("Child Thread Execution Completed");
        }
    }
}
