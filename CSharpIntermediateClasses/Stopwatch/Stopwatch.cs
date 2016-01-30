using System;
using System.Linq;
using System.Threading;

namespace Stopwatch
{
    public class Stopwatch
    {
        private static DateTime StartTime { get; set; }
        private static DateTime EndTime { get; set; }
        private static TimeSpan Duration { get; set; }

        private static bool _activated;
       

        public static void Start()
        {
            if(_activated)
                throw new InvalidOperationException();

            StartTime = DateTime.Now;
            Console.WriteLine($"Time started at {StartTime}");
            _activated = true;
        }

        public static void Stop()
        {
            EndTime = DateTime.Now;
            Console.WriteLine($"Time ended at {EndTime}");

            Duration = EndTime - StartTime;
            Console.WriteLine($"Time between start and end is {Duration}");
            _activated = false;
        }
    }
}