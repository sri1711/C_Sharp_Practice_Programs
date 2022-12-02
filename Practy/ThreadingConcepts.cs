using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practy
{
    class ThreadingConcepts
    {
        private static int length;

        static ThreadingConcepts()
        {
            length = int.Parse(Console.ReadLine());
        }

        static void  print_even()
        {
            for(int i = 0; i<=length ; i+=2)
            {
                Console.WriteLine("***Even Thread***");
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }

        static void print_odd()
        {
            for (int i = 1; i <= length; i += 2)
            {
                Console.WriteLine("***Odd Thread***");
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        //static void Main(string[] args)
        //{
        //    Thread Thread1 = new Thread(new ThreadStart(print_even));

        //    Thread Thread2 = new Thread(new ThreadStart(print_odd));

        //    Thread1.Start();
        //    Thread2.Start();

        //    Console.WriteLine("Main Thread Ends");


        //}
    }
}
