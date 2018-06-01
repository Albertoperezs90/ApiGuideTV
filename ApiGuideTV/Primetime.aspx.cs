using ApiGuideTV.Utilities.Format;
using ApiGuideTV.Utilities.Helpers;
using ApiGuideTV.Utilities.Mappers;
using ApiGuideTV.Utilities.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApiGuideTV
{
    public partial class Primetime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string epoch = Request.QueryString["epoch"];
            if (StringHelper.IsEpochValid(epoch))
            {
                LoadPrimetime(epoch);
            }else
            {
                Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
                Context.Response.Write(JsonMapper.MapErrorToJson(StatusHelper.GenerateStatus(CodeStatus.InvalidParameter)));
            }
        }

        private void LoadPrimetime(string epoch)
        {
            string json = Facade.Instance.LoadPrimetime(epoch);
            Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
            Context.Response.Write(json);
        }
    }
}