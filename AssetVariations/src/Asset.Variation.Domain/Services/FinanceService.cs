using Asset.Variations.Domain.Acl;
using Asset.Variations.Domain.Configuration.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Domain.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly IFinanceAcl _acl;

        public FinanceService(IFinanceAcl acl)
        {
            _acl = acl ?? throw new ArgumentNullException(nameof(IFinanceAcl));
        }

        public Task GetAssetVariations()
        {
            throw new NotImplementedException();
        }
    }
}
