using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGuideTV.BE
{
    public class Program
    {
        public string GenericType { get; set; }
        public string Id { get; set; }
        public Channel Channel { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Score { get; set; }
        public string Image { get; set; }
        public string EpochStart { get; set; }
        public string EpochEnd { get; set; }
    }
}