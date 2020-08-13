using System;
using System.Collections.Generic;
using System.Text;

namespace conCI
{
    public class SqlAccessData : IAccessData
    {
        public void ReadData()
        {
            Console.WriteLine("Reading from SQL");
        }

        public void WriteData(string name)
        {
            Console.WriteLine($"Writing to SQL");
        }

        public void Insert()
        {

        }

        public void UpdateById()
        {

        }
    }
}
