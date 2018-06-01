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
            return chain != null && chain.Length != 0;
        }

        public static Boolean IsEpochValid(string epoch)
        {
            try
            {
                if (!String.IsNullOrEmpty(epoch))
                {
                    long epochLong = Convert.ToInt64(epoch);
                }else
                {
                    return false;
                }
                

            } catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Boolean IsChannelIdValid(string channelId)
        {
            try
            {
                if (!String.IsNullOrEmpty(channelId))
                {
                    int channel = Convert.ToInt32(channelId);
                }else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}