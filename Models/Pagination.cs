using System;
namespace poundBustersCoreV1.Models
{
    public class Pagination
    {
        public int count_per_page { get; set; }
        public int total_count { get; set; }
        public int total_pages { get; set; }
        public _links _links { get; set; }

    }
}
