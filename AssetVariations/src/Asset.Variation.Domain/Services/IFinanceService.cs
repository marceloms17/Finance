using Asset.Variations.Domain.Acl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Domain.Services
{
    public interface IFinanceService
    {
        public Task GetAssetVariations();
    }
}
