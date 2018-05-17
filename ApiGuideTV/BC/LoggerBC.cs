using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BE;
using ApiGuideTV.DAC;

namespace ApiGuideTV.BC
{
    public class LoggerBC
    {
        private static LoggerBC instance;
        private LoggerBC() { }

        public static LoggerBC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggerBC();
                }

                return instance;
            }
        }

        public void LogDataToCloud(LogData data)
        {
            LoggerDAC.Instance.LogDataToCloud(data);
        }
    }
}