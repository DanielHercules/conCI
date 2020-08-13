using System;
using System.Collections.Generic;
using System.Text;

namespace conCI.Loggers
{
    class DatabaseLogger : ILogger
    {
        public void Write(string name)
        {
            Console.WriteLine($"Writing To Database");
        }

        public void WriteAsync(string name)
        {
            Console.WriteLine($"Writing To Database Async");
        }
    }
}
