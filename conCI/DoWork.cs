using System;
using System.Collections.Generic;
using System.Text;

namespace conCI
{
    public class DoWork
    {
        public EngineerClass Engineer { get; set; }
        public string TaskName { get; set; }

        private ILogger _logger;
        public IAccessData _sqlAccessData { get; set; }

        public DoWork(ILogger logger, IAccessData sqlAccessData)
        {
            _logger = logger;
            _sqlAccessData = sqlAccessData;
        }

        public void StartWork()
        {
            Console.WriteLine($"{TaskName} Started");
            ReadSomeData();
            WriteSomeData();
        }

        public void CompleteWork()
        {
            Console.WriteLine($"{TaskName} Complete");
        }

        private void ReadSomeData()
        {
            _logger.Write($"'{Engineer.EngineerName} : {TaskName} is reading data'");
            _sqlAccessData.ReadData();
        }

        private void WriteSomeData()
        {
            _logger.Write($"'{Engineer.EngineerName} : {TaskName} is writing data'");
            _sqlAccessData.WriteData(TaskName);
        }
    }
}