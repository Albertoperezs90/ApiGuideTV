using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Helpers
{
    public static class StringHelper
    {
        public static Boolean IsNotNullOrEmpty(string[] chain)
        {
            return chain.Length != 0 && chain != null;
        }
    }
}