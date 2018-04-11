using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities
{
    public class Constants
    {
        /// <summary>
        /// logger name
        /// </summary>
        public const string LoggerIdString = "ApiGuideTV";

        ///<summary>
        /// logger path
        /// </summary>
<<<<<<< HEAD
        public const string filePath = @"C:\ApiGuideTV.txt";
=======
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
>>>>>>> parent of cae6d49... Channel get created
    }
}