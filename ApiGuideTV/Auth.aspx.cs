using ApiGuideTV.Utilities.Format;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApiGuideTV
{
    public partial class Auth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenerateToken();
        }

        private void GenerateToken()
        {
            string token = Facade.Instance.GenerateToken();
            Context.Response.ContentType = HTMLHeaders.ContentTypeJson();
            Context.Response.Write(token);
        }
    }
}