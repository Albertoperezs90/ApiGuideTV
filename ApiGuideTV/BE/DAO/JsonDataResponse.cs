using ApiGuideTV.BE.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.BE
{
    /// <summary>
    /// Class to deserialize now.json response
    /// </summary>
    public class JsonDataResponse : BaseResponse
    {
        public List<List<string>> Data { get; set; }
        
    }
}