using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApiGuideTV.BE;
using ApiGuideTV.Utilities;
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
            string[] sortBy = Request.QueryString["sortBy"] != null ? Request.QueryString["sortBy"].Split(Constants.QuerySeparators) : null;
            string channel = Request.QueryString["channel"] ?? String.Empty;

            LoadNowGuideTV(sortBy, channel);
        }


        private void LoadNowGuideTV(string[] sortBy, string channel)
        {
            string json = Facade.Instance.LoadNowGuideTV(sortBy, channel);
            Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
            Context.Response.Write(json);
        }
    }
}