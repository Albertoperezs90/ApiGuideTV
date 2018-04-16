using ApiGuideTV.Utilities.Logger.Base;
using ApiGuideTV.Utilities.Status;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace ApiGuideTV.Utilities.Logger
{
    public class LoggerHelper
    {
        private static string rootPath = @Path.GetDirectoryName(Directory.GetCurrentDirectory());
        private const string logName = "ApiGuiaTV.txt";
        private static LoggerHelper logger;
        //private LoggerLevel loggerLevel;
        private const string loggerNCompany = "00000";
        private const string applicationId = "ApiGuideTV";

        static LoggerHelper()
        {
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
            if (param != null)
            {
                switch (loggerLevel)
                {
                    case LoggerLevel.File:
                        new EventLogger().Log(param.ToString());
                        break;
                    default:
                        break;
                }
            }
            
        }

        private class EventLogger : LoggerBase
        {
            public override void Log(string message)
            {
                if (message != null)
                {
                    using (StreamWriter w = GetLoggerWriter())
                    {
                        w.WriteLine(message);
                        w.Close();
                    }
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

        /// <summary>
        /// Get writer required by logger
        /// </summary>
        /// <returns>Writer which log need to use</returns>
        public static StreamWriter GetLoggerWriter()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Constants.logPath)
                .Append(Constants.FileLogSeparator)
                .Append(GenericHelper.GetCurrentDate())
                .Append(Constants.logExtension);

            return new StreamWriter(sb.ToString(), true);
        }
    }

    
}