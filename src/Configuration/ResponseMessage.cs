using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Configuration
{
    internal class ResponseMessage
    {
        public Response response { get; set; }
    }

    internal class Response
    {
        [JsonProperty(PropertyName = "error_code")]
        public int ErrorCode { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get; set; }
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }
        [JsonProperty(PropertyName = "auth")]
        public bool Auth { get; set; }
        [JsonProperty(PropertyName = "server_time")]
        public uint ServerTime { get; set; }
    }
}
