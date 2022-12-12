using Asset.Variations.Domain.Acl;
using Asset.Variations.Domain.Configuration.Options;
using Asset.Variations.Domain.Response;
using Asset.Variations.Infra.Configuration.Extensions;
using Asset.Variations.Infra.Relience;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Infra.Acl
{
    public class FinanceAcl : IFinanceAcl
    {
        private readonly IFlurlClient _client;
        private readonly FinanceOptions _options;

        public FinanceAcl(IFlurlClientFactory clientFactory, IOptions<FinanceOptions> options)
        {
            if (options is null) { throw new ArgumentNullException(nameof(options)); }
            if (clientFactory is null) { throw new ArgumentNullException(nameof(clientFactory)); }

            _options = options.Value ?? throw new ArgumentNullException(nameof(FinanceOptions));
            _client = clientFactory.Get(_options.Url);
        }

        public async Task GetFinanceAsync ()
        {
            //TODO-- terminar de configurar as polices
            //var result = await Polices
            //            .PolicyWrapper(_options.Timeout)
            //            .ExecuteAsync(()=> $"/v{_options.Version}/finance/chart/PETR4.SA"
            //            .WithClient(_client)
            //            .AllowHttpStatus()
            //            .GetAsync()).ReceiveResult<FinanceResponse>();

        }
    }
}
