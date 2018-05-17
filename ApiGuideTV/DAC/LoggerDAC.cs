using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using ApiGuideTV.BE;
using ApiGuideTV.Utilities;
using ApiGuideTV.Utilities.Format;

namespace ApiGuideTV.DAC
{
    public class LoggerDAC
    {
        private static LoggerDAC instance;

        private LoggerDAC() { }

        public static LoggerDAC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggerDAC();
                }
                return instance;
            }
        }


        public void LogDataToCloud(LogData data)
        {
            using (WebClient client = new WebClient())
            {
                var values = new NameValueCollection();
                values.Add("entry.588016656", data.Id);
                values.Add("entry.225423011", data.Type);
                values.Add("entry.789444251", data.MethodName);
                values.Add("entry.1576147630", data.Param);

                Uri uri = new Uri(Constants.logPath);
                byte[] response = client.UploadValues(uri, HTMLHeaders.MethodPost(), values);
                var responseString = Encoding.UTF8.GetString(response);
            }    
        }
    }
}