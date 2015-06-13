﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitchLib.Model.Static
{
    public class Ingest
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("availability")]
        public double Availability { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("url_template")]
        public string UrlTemplate { get; set; }
    }
}