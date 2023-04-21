using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    internal class Stop_Watch
    {
        public void StopWatch()
        {
            Stopwatch stop_watch = new Stopwatch();
            Console.WriteLine("Press Enter to start");
            Console.Read();
            while (true)
            {
                stop_watch.Start();
                Thread.Sleep(1000);
                stop_watch.Stop();
                TimeSpan tspan = stop_watch.Elapsed;
                Console.Clear();
                string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
                tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
                Console.WriteLine(" RunTime " + elapsedTime);
            }
        }
    }
}
