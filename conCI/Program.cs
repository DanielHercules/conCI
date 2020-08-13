using System;
using System.Threading.Tasks;
using conCI.DataAccess;
using conCI.Loggers;

namespace conCI
{
    class Program
    {
        static void Main(string[] args)
        {


            ILogger logger = new DatabaseLogger();
            IAccessData accessData = FactoryClass.CreasteSQLAccessClass();

            EngineerClass dan = new EngineerClass
            {
                EngineerName = "Dan"
            };

            DoWork work = new DoWork(logger, accessData)
            {
                Engineer = dan,
                TaskName = "Task 1"
            };

            work.StartWork();
            work.CompleteWork();


            IAccessData accessData1 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData2 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData3 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData4 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData5 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData6 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData7 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData8 = FactoryClass.CreasteSQLAccessClass();
            IAccessData accessData9 = FactoryClass.CreasteSQLAccessClass();

        }
    }
}
