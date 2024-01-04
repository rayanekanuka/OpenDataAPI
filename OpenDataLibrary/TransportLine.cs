using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenDataLibrary
{
    public class TransportLine
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("lines")]
        public List<string> lines { get; set; }


    }
}
