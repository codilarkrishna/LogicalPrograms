using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class SampleAsyncAndAwait
    {
        static void Main89(string[] args)
        {
            var task1 = StartOne();
            var task2 = StartTwo();
            var task3 = StartThree();
            
            Task.WaitAll(task1,task2,task3);

            Console.WriteLine("Main Thread Execution Completed");
            Console.ReadLine();
        }
        static void PrintInfo(string str)
        {
            Console.WriteLine("Hello From : {0}", str);
        }
        static async Task StartOne()
        {
            await Task.Run(() =>
            {
                PrintInfo("StartOne");
                Thread.Sleep(1000);
            });
            Console.WriteLine("Start One");
        }
        static async Task StartTwo()
        {
            await Task.Run(() =>
            {
                PrintInfo("StartTwo");
                Thread.Sleep(1000);
            });
            Console.WriteLine("Start Two");
        }
        static async Task StartThree()
        {
            await Task.Run(() =>
            {
                PrintInfo("StartThree");
                Thread.Sleep(1000);
            });
            Console.WriteLine("Start Three");
        }
    }
}
