using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Domain.Configuration.Options
{
    public class FinanceOptions
    {
        public string Url { get; set; }
        public int Timeout { get; set; }
        public int Version { get; set; }
    }
}
