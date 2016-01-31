using System;
using System.Linq;
using System.Threading;

namespace Stopwatch
{
    public class Stopwatch
    {
        private static DateTime _startTime;
        private static DateTime _endTime;
        private static TimeSpan _duration;

        private static bool _activated;
       

        public static void Start()
        {
            if(_activated)
                throw new InvalidOperationException();

            _startTime = DateTime.Now;
            Console.WriteLine($"Time started at {_startTime}");
            _activated = true;
        }

        public static void Stop()
        {
            if (!_activated)
                throw new InvalidOperationException("Stopwatch is not running");

            _endTime = DateTime.Now;
            Console.WriteLine($"Time ended at {_endTime}");

            GetInterval();
            _activated = false;
        }

        private static void GetInterval()
        {
            _duration = _endTime - _startTime;
            Console.WriteLine($"Time between start and end is {_duration}");
        }
    }
}