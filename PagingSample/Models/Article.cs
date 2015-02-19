using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace PagingSample.Models
{
    public class Article
    {
        public string Title { get; set; }

        [JsonIgnore]
        public DateTime Time { get; set; }

        public string _Time { get { return Time.ToString("MM-dd-yyyy"); } }

        public string Content { get; set; }
    }
}