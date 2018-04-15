using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities
{
    public class Constants
    {
        /// <summary>
        /// Logger name
        /// </summary>
        public const string LoggerIdString = "ApiGuideTV";

        ///<summary>
        /// Logger path
        /// </summary>
        public const string logPath = @"C:/log/ApiGuideTV";

        /// <summary>
        /// Log Extension
        /// </summary>
        public const string logExtension = ".log";

        /// <summary>
        /// Logger Separator
        /// </summary>
        public const string FileLogSeparator = @" - ";

        /// <summary>
        /// Logger header text, start every day
        /// </summary>
        public const string LoggerHeader = "********";

        /// <summary>
        /// Json endpoint
        /// </summary>
        public const string JsonEndPoint = ".json";
    }
}