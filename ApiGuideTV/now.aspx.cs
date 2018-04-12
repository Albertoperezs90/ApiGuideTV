using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApiGuideTV.BE;
using ApiGuideTV.Utilities.Format;
using ApiGuideTV.Utilities.Logger;
using ApiGuideTV.Utilities.Mappers;
using ApiGuideTV.Utilities.Status;
using Newtonsoft.Json;

namespace ApiGuideTV
{
    public partial class now : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadNowGuideTV();
        }


        private void LoadNowGuideTV()
        { 
            #region Log method input
            LoggerHelper.LogEntryParams(LoggerLevel.File, "LoadNowGuideTV", null);
            #endregion

            using (WebClient response = new WebClient())
            {
                try
                {
                    var jsonResponse = response.DownloadString(System.Configuration.ConfigurationManager.ConnectionStrings["programsNow"].ConnectionString);
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);

                    var programsResponse = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                    string json = JsonConvert.SerializeObject(programsResponse);
                    Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
                    Context.Response.Write(json);

                    #region Log method output
                    LoggerHelper.LogOuterParams(LoggerLevel.File, "GetDataItem", null);
                    #endregion

                }
                catch (WebException e)
                {
                    LoggerHelper.LogExceptionParams(LoggerLevel.File, "LoadNowGuideTV", e);
                }
            }
        }
    }
}