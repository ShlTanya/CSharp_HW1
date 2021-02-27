using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW11.Exercise2
{
    class Exercise2
    {
        private int _lastprint;
        static readonly object locker = new object();

        public Exercise2()
        {
            _lastprint = 0;
        }

        public void PrintFirst()
        {
            lock (locker)
            {
                if (_lastprint == 0)
                {
                    _lastprint = 1;
                    Console.WriteLine($"first \tthreadId{Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public void PrintSecond()
        {
            lock (locker)
            {
                if (_lastprint == 1)
                {
                    _lastprint = 2;
                    Console.WriteLine($"second \tthreadId{Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public void PrintThird()
        {
            lock (locker)
            {
                if (_lastprint == 2)
                {
                    _lastprint = 0;
                    Console.WriteLine($"third \tthreadId{Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }
    }
}
