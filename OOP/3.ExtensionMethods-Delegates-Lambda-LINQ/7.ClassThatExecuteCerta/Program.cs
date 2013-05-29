/*
    7.Using delegates write a class Timer that has can execute certain method at each t seconds.
 */
using System;

namespace ExecuteAtEachTSeconds
{
    class Program
    {
        public static void Main()
        {
            Timer t = new Timer(ExecuteAtEachSecond.ExecuteMethod); 
            t("This sentence repeats every couple seconds...", 3); 
        }
    }
}