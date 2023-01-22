using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class lockSample
    {

    }

    class MainClass
    {
        static readonly object pblock = new object();
        static void printInfo()
        {
            lock (pblock)
            {
                for (int i = 0; i <=4; i++)
                {
                    Console.WriteLine("value i : {0}",i);
                }
            }
        }

        static void Main45()
        {
            Thread thr1 = new Thread(new ThreadStart(printInfo));
            Thread thr2 = new Thread(new ThreadStart(printInfo));
            thr1.Start();
            thr2.Start();
            Console.ReadLine();
        }
    }
}
