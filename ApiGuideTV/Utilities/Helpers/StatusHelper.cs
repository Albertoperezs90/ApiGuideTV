using ApiGuideTV.BE;
using ApiGuideTV.Utilities.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.Utilities.Helpers
{
    public static class StatusHelper
    {
        public static BE.Status GenerateStatus(CodeStatus errorStatus)
        {
            BE.Status status = new BE.Status()
            {
                Code = errorStatus.ToString()
            };

            switch (errorStatus)
            {
                case CodeStatus.Successful: status.Message =  "OK";
                    break;
                case CodeStatus.InvalidParameter: status.Message = "There was a problem with parameter passed";
                    break;
                case CodeStatus.Timeout: status.Message = "No response from server, try again later";
                    break;
                case CodeStatus.Unknown: status.Message = "What the hell just happened? Check log plz";
                    break;
                default: status.Message = "?";
                    break;
            }

            return status;
        }
    }
}