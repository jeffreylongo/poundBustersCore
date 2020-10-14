using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace poundBustersCoreV1.Models
{
    public class PetFinderResponse
    {
        [JsonProperty("animals")]
        public IList<Pet> Pets { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
