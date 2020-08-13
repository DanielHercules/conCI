using System;
using System.Collections.Generic;
using System.Text;
using conCI.DataAccess;

namespace conCI
{
    public static class FactoryClass
    {
        public static IAccessData CreasteSQLAccessClass()
        {
            return new NewSQLAccessData();
        }

        public static IAccessData CreateOracleDataAccessClass()
        {
            return new OracleAccessData();
        }
    }
}
