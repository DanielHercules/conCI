using System;
using System.Collections.Generic;
using System.Text;

namespace conCI
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string name)
        {
            Console.WriteLine($"Writing To Console");
        }

        public void WriteAsync(string name)
        {
            Console.WriteLine($"Writing To Console Async");
        }
    }
}
