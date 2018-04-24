using ApiGuideTV.BC;
using ApiGuideTV.BE;
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
    public class LoggerHelper : LoggerBase
    {
        private static LoggerHelper logger;


        static LoggerHelper()
        {
            logger = new LoggerHelper();
        }


        /// <summary>
        /// Save method name and params of method based on type passed
        /// </summary>
        /// <param name="methodName">Name of method who fire this</param>
        /// <param name="param">Params of method</param>
        public static void LogEntryParams(LoggerLevel level, string methodName, string param)
        {

        }


        /// <summary>
        /// Save method name and params of method based on type passed
        /// </summary>
        /// <param name="methodName">Name of method who fire this</param>
        /// <param name="param">Params of method</param>
        public static void LogOuterParams(LoggerLevel level, string methodName, string param)
        {
            LoggerBC.Instance.LogDataToCloud(new LogData()
            {
                Id = "0",
                Type = level.ToString(),
                MethodName = methodName,
                Param = param
            });
        }

        /// <summary>
        /// Save method name and params of method based on type passed
        /// </summary>
        /// <param name="methodName">Name of method who fire this</param>
        /// <param name="param">Params of method</param>
        public static void LogExceptionParams(LoggerLevel level, string methodName, Exception ex)
        {
            LoggerBC.Instance.LogDataToCloud(new LogData()
            {
                Id = "0",
                Type = level.ToString(),
                MethodName = methodName,
                Param = ex.Message
            });
        }
    }

    
}