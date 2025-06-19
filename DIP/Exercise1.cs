using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{

    // not implement DIP
    //internal class FileLogger
    //{
    //    public void LogToFile(string log)
    //    {
    //        Console.WriteLine(log);
    //    }
    //}
    //public class MissionController
    //{
    //    FileLogger logger = new FileLogger();

    //    public void SaveLog(string msg)
    //    {
    //        logger.LogToFile(msg);
    //    }
    //}

    //

    //implement DIP
    internal interface ILoger
    {
        public void Log(string log);
    }
    internal class FileLogger : ILoger
    {
        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }
    public class MissionController
    {
        private ILoger logger;

        public void SaveLog(string msg)
        {
            logger.Log(msg);
        }
    }
}
