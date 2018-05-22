using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using ApiGuideTV.BE;
using ApiGuideTV.BE.DAO;
using ApiGuideTV.Utilities.Format;
using ApiGuideTV.Utilities.Helpers;
using ApiGuideTV.Utilities.Logger;
using ApiGuideTV.Utilities.Mappers;
using ApiGuideTV.Utilities.Status;
using Newtonsoft.Json;

namespace ApiGuideTV.BC
{
    public class ProgramBC
    {
        private static ProgramBC instance;

        private ProgramBC () { }

        public static ProgramBC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProgramBC();
                }

                return instance;
            }
        }

        public ProgramsResponse LoadNowGuideTV(string[] sortBy, string channel)
        {
            ProgramsResponse programs = new ProgramsResponse();

            programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Unknown);

            try
            {
                string uri = System.Configuration.ConfigurationManager.ConnectionStrings["programsNow"].ToString();

                using (WebClient wc = new WebClient())
                {
                    string jsonResponse = wc.DownloadString(uri);
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);
                    programs = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                }

                if (!String.IsNullOrEmpty(channel))
                {
                    programs.response = programs.response.OrderBy(p => p.IdChannel == channel).ToList();
                }

                if (StringHelper.IsNotNullOrEmpty(sortBy))
                {

                }

                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Successful);

                LoggerHelper.LogOuterParams(LoggerLevel.Trace, "LoadNowGuideTV", ReflectionHelper.GetPropertiesToBeLogged(programs) );

            } catch (Exception ex)
            {
                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Timeout);
                LoggerHelper.LogExceptionParams(LoggerLevel.Exception, "LoadNowGuideTV", ex);
            }

            return programs;
        }
        

        public ProgramsResponse LoadPrimetime (string epoch)
        {
            ProgramsResponse programs = new ProgramsResponse();

            programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Unknown);

            try
            {
                string uri = System.Configuration.ConfigurationManager.ConnectionStrings["primetime"].ToString();
                uri += "?" + epoch;

                using (WebClient wc = new WebClient())
                {
                    string jsonResponse = wc.DownloadString(uri);
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);
                    programs = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                }

                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Successful);

                LoggerHelper.LogOuterParams(LoggerLevel.Trace, "LoadPrimetime", ReflectionHelper.GetPropertiesToBeLogged(programs));

            } catch (Exception ex)
            {
                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Timeout);
                LoggerHelper.LogExceptionParams(LoggerLevel.Exception, "LoadPrimetime", ex);
            }

            return programs;
        }


        public ProgramsResponse LoadChannelGuide(string idChannel)
        {
            ProgramsResponse programs = new ProgramsResponse();

            programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Unknown);

            try
            {
                string uri = System.Configuration.ConfigurationManager.ConnectionStrings["channelId"].ToString();
                uri += "?" + idChannel;

                using (WebClient wc = new WebClient())
                {
                    string jsonResponse = wc.DownloadString(uri);
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);
                    programs = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                }

                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Successful);

                LoggerHelper.LogOuterParams(LoggerLevel.Trace, "LoadChannelGuide", ReflectionHelper.GetPropertiesToBeLogged(programs));
            }
            catch (Exception ex)
            {
                programs.CodeStatus = StatusHelper.GenerateStatus(CodeStatus.Timeout);
                LoggerHelper.LogExceptionParams(LoggerLevel.Exception, "LoadChannelGuide", ex);
            }

            return programs;
        }
    }
}