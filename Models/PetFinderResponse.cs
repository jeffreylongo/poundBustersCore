using System;
using System.Collections.Generic;

namespace poundBustersCoreV1.Models
{
    public class PetFinderResponse
    {
        public IList<Pet> animals { get; set; }
        public Pagination pagination { get; set; }
    }
}
