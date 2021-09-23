using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace BasicLogicalPrograms
{
    class StopWatch 
    {
        public void Time()
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            timer.Stop();
            Console.WriteLine("Time in HR:MIN:SEC "+ timer.Elapsed);
        }
    }
}
