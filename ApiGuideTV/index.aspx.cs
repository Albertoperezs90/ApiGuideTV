using ApiGuideTV.BE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApiGuideTV
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDataItem();
        }

        private void GetDataItem()
        {
            using (WebClient response = new WebClient())
            {
                var json = response.DownloadString("https://api.miguia.tv/1/es_ES/channel/now.json");

                JsonDataResponse jsonResponse = JsonConvert.DeserializeObject<JsonDataResponse>(json);

                foreach (List<string> program in jsonResponse.data)
                {
                    ProgramResponse programResponse = new ProgramResponse()
                    {
                        Category = program[0],
                        Id = program[1],
                        Id2 = program[2],
                        Type = program[3],
                        Name = program[4],
                        AnotherCategory = program[5],
                        Nose = program[6],
                        Nil = program[7],
                        Poster = program[8],
                        EpochStart = program[9],
                        EpochEnd = program[10]
                    };
                }
            }
        }
    }
}