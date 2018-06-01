using ApiGuideTV.BE;
using ApiGuideTV.Utilities;
using ApiGuideTV.Utilities.Format;
using ApiGuideTV.Utilities.Helpers;
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
            if (StringHelper.IsChannelIdValid(idChannel))
            {
                LoadChannelData(idChannel);
            }
        }

        private void LoadChannelData(string idChannel)
        {
            string json = Facade.Instance.LoadChannelGuide(idChannel);
            Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
            Context.Response.Write(json);
        }
    }
}