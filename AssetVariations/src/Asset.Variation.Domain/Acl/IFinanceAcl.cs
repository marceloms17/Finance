using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Domain.Acl
{

    public interface IFinanceAcl
    {
        public Task GetFinanceAsync();
    }
}
