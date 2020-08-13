using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace conCI
{
    public class FileLogger : ILogger
    {
        public void Write(string name)
        {
            Console.WriteLine($"Writing To File");
        }

        public void WriteAsync(string name)
        {
            Console.WriteLine($"Writing To File Async");
        }

        public void WriteDebug(string name)
        {
            Console.WriteLine($"Writing To Debug");
            //Write To Database
        }
    }
}
