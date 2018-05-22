using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Status
{
    public enum CodeStatus
    {
        Successful = 0,
        Unknown = -1,
        InvalidParameter = -100,
        Timeout = -200
    }
}