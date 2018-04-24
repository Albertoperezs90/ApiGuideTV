using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiGuideTV.BE.Base;

namespace ApiGuideTV.BE
{
    public class ChannelResponse : BaseResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}