using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Logger.Base
{
    public abstract class LoggerBase
    {
        public abstract void Log(string message);
    }
}