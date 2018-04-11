using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Status
{
    public class LoggerStatus
    {
        static LoggerStatus()
        {
            
        }

        public enum Target
        {
            File,
            Database,
            EventLog
        }
    }
}