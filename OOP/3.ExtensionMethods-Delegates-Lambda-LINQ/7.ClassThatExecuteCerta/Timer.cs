﻿using System;
using System.Diagnostics;

namespace ExecuteAtEachTSeconds
{
    public delegate void Timer(string message, int seconds); //this is delegate

    public class ExecuteAtEachSecond
    {
        public static void ExecuteMethod(string message, int seconds)  // method with the same parameters like delegate
        {
            Stopwatch sw = new Stopwatch(); 
            sw.Start(); //start timing
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds * 1000) //convert second in milisecond
                {
                    Console.WriteLine(message);
                    sw.Restart(); 
                }
            }
        }
    }
}