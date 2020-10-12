using System;
using System.Collections.Generic;

namespace poundBustersCoreV1.Models
{
    public class Pet
    {
        public int id { get; set; }
        public int organizationId { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string species { get; set; }
        public Breed breeds { get; set; }
        public Color colors { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string size { get; set; }
        public string coat { get; set; }
        public Attribute attributes { get; set; }
        public List<string> tags { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> photos { get; set; }
        public List<string> videos { get; set; }
        public string status { get; set; }
        public DateTime published { get; set; }
        public Contact contact { get; set; }
        public Links link { get; set; }
    }
}

