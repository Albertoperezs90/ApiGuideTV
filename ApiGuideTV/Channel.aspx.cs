using ApiGuideTV.BE;
using ApiGuideTV.Utilities;
using ApiGuideTV.Utilities.Format;
using ApiGuideTV.Utilities.Logger;
using ApiGuideTV.Utilities.Mappers;
using ApiGuideTV.Utilities.Status;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApiGuideTV
{
    public partial class Channel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idChannel = Request.QueryString["id"];
            if (idChannel != null)
            {
                LoadChannelData(idChannel);
            }
        }

        private void LoadChannelData(string idChannel)
        {
            using (WebClient response = new WebClient())
            {
                try
                {
                    StringBuilder request = new StringBuilder();
                    request.Append(System.Configuration.ConfigurationManager.ConnectionStrings["channelId"].ConnectionString);
                    request.Append(idChannel);
                    request.Append(Constants.JsonEndPoint);
                    string jsonResponse = response.DownloadString(request.ToString());
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);

                    var programsResponse = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                    string json = JsonConvert.SerializeObject(programsResponse);
                    Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
                    Context.Response.Write(json);

                    #region Log method output
                    LoggerHelper.LogOuterParams(LoggerLevel.File, "LoadChannelData", null);
                    #endregion

                }
                catch (WebException e)
                {
                    LoggerHelper.LogExceptionParams(LoggerLevel.File, "LoadChannelData", e);
                }
            }
        }
    }
}