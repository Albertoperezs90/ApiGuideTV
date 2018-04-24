using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Status
{
    /// <summary>
    /// <para>Succesful -> 0</para>
    /// <para>Exception -> 1</para>
    /// <para>Trace -> 2</para>
    /// </summary>
    public enum LoggerLevel
    {
        Succesful = 0,
        Exception = 1,
        Trace = 2
    }
}