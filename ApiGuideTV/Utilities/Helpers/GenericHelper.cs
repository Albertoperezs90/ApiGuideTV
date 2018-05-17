using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using ApiGuideTV.BE;
using ApiGuideTV.BE.Base;
using ApiGuideTV.Utilities.Mappers;
using Newtonsoft.Json;

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
    }
}