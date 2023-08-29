using Newtonsoft.Json;

namespace v2rayN.Mode
{
    internal class NaiveConfig
    {
        public List<string> listen { get; set; }
        public string proxy { get; set; }

        [JsonProperty("host-resolver-rules")]
        public string? host_resolver_rules { get; set; }

        [JsonProperty("resolver-range")]
        public int? insecure_concurrency { get; set; }

        public string log { get; set; } = "";
    }
}
