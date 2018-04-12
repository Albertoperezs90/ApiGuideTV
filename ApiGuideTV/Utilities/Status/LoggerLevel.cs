using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Status
{
    /// <summary>
    /// <para>Succesful -> 0</para>
    /// <para>Database -> 1</para>
    /// <para>File -> 2</para>
    /// </summary>
    public enum LoggerLevel
    {
        Unknown = 0,
        Database = 1,
        File = 2
    }
}