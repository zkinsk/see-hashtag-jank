using System;

namespace CSharpIntermediate
{
    public class StopWatch
    {
        private bool _started;
        private DateTime _startTime;
        private DateTime _endTime;
        public void Start()
        {
            if (_started) throw new InvalidOperationException("Stopwatch Already running");
            _startTime = DateTime.Now;
            _started = true;
        }

        public void Stop()
        {
            _endTime = DateTime.Now;
            _started = false;
            var interval = _endTime - _startTime;
            var elapsedTime = $"{interval.Hours.ToString("D2")}:{interval.Minutes.ToString("D2")}:{interval.Seconds.ToString("D2")}:{interval.Milliseconds}";
            Console.WriteLine(elapsedTime);
        }
    }
}