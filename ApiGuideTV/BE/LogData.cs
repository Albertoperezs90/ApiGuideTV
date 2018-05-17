using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.BE
{
    public class LogData
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string MethodName { get; set; }
        public string Param { get; set; }
    }
}