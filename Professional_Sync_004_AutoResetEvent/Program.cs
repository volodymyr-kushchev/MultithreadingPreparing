﻿using System;
using System.Threading;

namespace Professional_Sync_004_AutoResetEvent
{
    class Program
    {
        static AutoResetEvent auto = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            new Thread(Function1).Start();
            new Thread(Function2).Start();

            Thread.Sleep(500);

            Console.WriteLine("Please, enter press any button");
            Console.ReadKey();
            auto.Set();
            auto.Set();

            Console.ReadKey();
        }

        static void Function1()
        {
            Console.WriteLine("Thread 1 is running and wainting for a signal");
            auto.WaitOne();
            Console.WriteLine("Thread 1 is completed");
        }

        static void Function2()
        {
            Console.WriteLine("Thread 2 is running and wainting for a signal");
            auto.WaitOne();
            Console.WriteLine("Thread 2 is completed");
        }
    }
}
