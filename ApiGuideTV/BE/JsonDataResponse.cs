using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.BE
{
    public class JsonDataResponse
    {
        public List<List<string>> data { get; set; }

        public partial class Quote
        {
            public static Quote FromJson(string json) =>
                JsonConvert.DeserializeObject<Quote>(json, Converter.Settings);
        }
    

        public class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
}