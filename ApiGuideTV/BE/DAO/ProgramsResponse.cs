using ApiGuideTV.BE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.BE.DAO
{
    public class ProgramsResponse : BaseResponse
    {
        public List<ProgramResponse> response { get; set; }
    }
}