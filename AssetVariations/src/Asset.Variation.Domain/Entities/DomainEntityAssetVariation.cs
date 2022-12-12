using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Domain.Entities
{
    public class DomainEntityAssetVariation
    {        
        public int CategoryGroupCode { get; set; }
        public string CategoryGroupDescription { get; set; }
        public bool? CategoryGroupShowOnSearch { get; set; }
        public string? CategoryGroupText { get; set; }
        public int? CategoryGroupExibitionOrdering { get; set; }
    }
}
