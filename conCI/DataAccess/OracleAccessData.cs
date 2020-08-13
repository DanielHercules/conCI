using System;
using System.Collections.Generic;
using System.Text;

namespace conCI
{
    public class OracleAccessData : IAccessData
    {
        public void ReadData()
        {
            Console.WriteLine("Reading from Oracle");
        }

        public void WriteData(string name)
        {
            Console.WriteLine($"Writing to Oracle");
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void UpdateById()
        {
            throw new NotImplementedException();
        }
    }
}
