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
            get
            {
                if (instance == null)
                {
                    instance = new LoggerHelper();
                }
                return instance;
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