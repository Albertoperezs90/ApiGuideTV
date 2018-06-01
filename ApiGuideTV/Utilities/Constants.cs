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
        public const string LoggerIdString = "TeletextoDigital.API";

        ///<summary>
        /// Logger path
        /// </summary>
        public static readonly string logPath = System.Configuration.ConfigurationManager.ConnectionStrings["logDrive"].ToString();

        /// <summary>
        /// Number of company
        /// </summary>
        private const string loggerNCompany = "00000";

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

        public static readonly char[] QuerySeparators = { ',' };
    }
}