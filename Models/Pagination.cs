using System;
using Newtonsoft.Json;


namespace poundBustersCoreV1.Models
{
    public class Pagination
    {

        [JsonProperty("count_per_page")]
        public int Count_per_page { get; set; }
        [JsonProperty("total_count")]
        public int Total_count { get; set; }
        [JsonProperty("total_pages")]
        public int Total_pages { get; set; }
        [JsonProperty("_links")]
        public _links Links { get; set; }

    }
}
