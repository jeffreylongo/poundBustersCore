using System;
using System.Collections.Generic;

namespace poundBustersCoreV1.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public int OrganizationId { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public Breed Breeds { get; set; }
        public Color Colors { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Coat { get; set; }
        public Attribute Attributes { get; set; }
        public List<string> Tags { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Videos { get; set; }
        public string Status { get; set; }
        public DateTime Published { get; set; }
        public Contact Contact { get; set; }
        public Links Link { get; set; }
    }
}

