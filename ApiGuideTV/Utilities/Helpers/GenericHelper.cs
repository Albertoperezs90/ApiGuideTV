using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ApiGuideTV.Utilities
{
    public class GenericHelper
    {
        private static GenericHelper helper;

        static GenericHelper()
        {
            helper = new GenericHelper();
        }

        /// <summary>
        /// Create a new log file with a header and a current date
        /// </summary>
        public static void CreateLoggerFile()
        {
            StringBuilder initialLogMessage = new StringBuilder();
            initialLogMessage.Append(Constants.LoggerHeader)
                .Append(GetCurrentDate())
                .Append(Constants.LoggerHeader);

            try
            {
                using (StreamWriter sw = new StreamWriter(initialLogMessage.ToString(), true))
                {
                    sw.WriteLine(initialLogMessage);
                    sw.Close();
                }
            } catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Get current date
        /// </summary>
        /// <returns>Current date (dd-MM-yyyy)</returns>
        public static string GetCurrentDate()
        {
            return DateTime.Today.ToString("dd-MM-yyyy");
        }

        /// <summary>
        /// Get current time 
        /// </summary>
        /// <returns>Current time (HH:mm:ss)</returns>
        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Check if a file to log data from today exists
        /// </summary>
        /// <returns>true if Logger is already created</returns>
        public static Boolean LoggerExist()
        {
            StringBuilder logPath = new StringBuilder();
            logPath.Append(Constants.logPath)
                .Append(Constants.FileLogSeparator)
                .Append(GetCurrentDate())
                .Append(Constants.logExtension);

            if (!File.Exists(logPath.ToString()))
            {
                return false;
            }
            return true;
        }
    }
}