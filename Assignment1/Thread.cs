using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment1
{
    class Threading
    {
        const int numberLimit = 20;
        static readonly object _lockMonitor = new object();
        //static void Main(string[] args)
        //{
        //    Thread EvenThread = new Thread(PrintEvenNumbers);
        //    Thread OddThread = new Thread(PrintOddNumbers);
        //    EvenThread.Start();
        //    Thread.Sleep(100);
        //    OddThread.Start();
        //    //OddThread.Join();
        //    //EvenThread.Join();
        //    Console.ReadKey();
        //}

        static void PrintEvenNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                Console.WriteLine("Entered into monitor 1 : " + _lockMonitor);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    Console.WriteLine("Pulse of monitor 1 : " + _lockMonitor);
                    bool isLast = false; 
                    if (i == numberLimit)
                    {
                        isLast = true;
                    }

                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                        Console.WriteLine("Wait of monitor 1 : " + _lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }

        static void PrintOddNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    bool isLast = false;
                    if (i == numberLimit - 1)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }
    }
}


