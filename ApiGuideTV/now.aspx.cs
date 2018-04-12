using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApiGuideTV.BE;
using ApiGuideTV.Utilities.Mappers;
using Newtonsoft.Json;

namespace ApiGuideTV
{
    public partial class now : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDataItem();
        }

        private new void GetDataItem()
        {
            using (WebClient response = new WebClient())
            {
                try
                {
                    var jsonResponse = response.DownloadString(System.Configuration.ConfigurationManager.ConnectionStrings["programsNow"].ConnectionString);
                    JsonDataResponse jsonObject = JsonConvert.DeserializeObject<JsonDataResponse>(jsonResponse);

                    var programsResponse = JsonMapper.MapJsonDataResponseToProgramResponse(jsonObject);
                    string json = JsonConvert.SerializeObject(programsResponse);
                    Context.Response.ContentType = "application/json";
                    Context.Response.Write(json);

                } catch (WebException e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
    }
}