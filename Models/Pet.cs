using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace poundBustersCoreV1.Models
{
    public class Pet
    {
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("organizationId")]
        public int OrganizationId { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("species")]
        public string Species { get; set; }
        [JsonProperty("breeds")]
        public Breed Breeds { get; set; }
        [JsonProperty("colors")]
        public Color Colors { get; set; }
        [JsonProperty("age")]
        public string Age { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("coat")]
        public string Coat { get; set; }
        [JsonProperty("attributes")]
        public Attribute Attributes { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("photos")]
        public List<string> Photos { get; set; }
        [JsonProperty("videos")]
        public List<string> Videos { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("published")]
        public DateTime Published { get; set; }
        [JsonProperty("contact")]
        public Contact Contact { get; set; }
        [JsonProperty("link")]
        public Links Link { get; set; }
    }
}

