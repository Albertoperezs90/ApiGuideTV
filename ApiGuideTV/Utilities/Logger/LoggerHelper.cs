using ApiGuideTV.Utilities.Logger.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Logger
{
    public class LoggerHelper
    {
        private static LoggerHelper instance;

        public static LoggerHelper Instance
        {
<<<<<<< HEAD
            get
            {
                if (instance == null)
                {
                    instance = new LoggerHelper();
                }
                return instance;
=======
            logger = new LoggerHelper();

            if (!GenericHelper.LoggerExist())
            {
                GenericHelper.CreateLoggerFile();
            }
        }

        public static void LogEntryParams(Enum loggerLevel, string methodName, string[] param)
        {

        }

        public static void LogExceptionParams(LoggerLevel loggerLevel, string methodName, Exception e)
        {

        }

        /// <summary>
        /// Save method name and params of method based on type passed
        /// </summary>
        /// <param name="loggerLevel">Type of log to be used</param>
        /// <param name="methodName">Name of method who fire this</param>
        /// <param name="param">Params of method</param>
        public static void LogOuterParams(LoggerLevel loggerLevel, string methodName, string[] param)
        {
            switch (loggerLevel)
            {
                case LoggerLevel.File:
                    new EventLogger().Log(param.ToString());
                    break;
                default:
                    break;
>>>>>>> parent of cae6d49... Channel get created
            }
        }

        private class EventLogger : LoggerBase
        {
            public override void Log(string message)
            {
                using (StreamWriter sw = new StreamWriter(Constants.filePath))
                {
                    sw.WriteLine(message);
                    sw.Close();
                }
            }
        }

        private class DBLogger : LoggerBase
        {
            public override void Log(string message)
            {
                throw new NotImplementedException();
            }
        }
    }

    
}