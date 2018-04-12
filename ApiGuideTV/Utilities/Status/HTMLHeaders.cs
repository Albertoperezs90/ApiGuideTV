using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Format
{
    public class HTMLHeaders
    {
        private static HTMLHeaders headers;

        static HTMLHeaders()
        {
            headers = new HTMLHeaders();
        }
        public static string MethodGet()
        {
            return "GET";
        }

        public static string ContentTypeJson()
        {
            return "application/json";
        }
    }
}