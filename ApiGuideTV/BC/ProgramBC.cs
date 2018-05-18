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
                    programs.response = programs.response.Where(p => p.IdChannel == channel).ToList();
                }

                LoggerHelper.LogOuterParams(LoggerLevel.Trace, "LoadNowGuideTV", ReflectionHelper.GetPropertiesToBeLogged(programs) );

            } catch (Exception ex)
            {
                LoggerHelper.LogExceptionParams(LoggerLevel.Exception, "LoadNowGuideTV", ex);
            }

            return programs;
        } 
    }
}