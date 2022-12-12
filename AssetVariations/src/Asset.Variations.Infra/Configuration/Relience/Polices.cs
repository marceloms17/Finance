using Flurl.Http;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using Polly.Timeout;
using Polly.Wrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Infra.Relience
{
    public static class Polices
    {
        public static AsyncPolicyWrap<HttpResponseMessage> PolicyWrapper( int timeout = 10)
        {
            return RetryPolicy.WrapAsync(Timeout(timeout));
        }

        public static AsyncTimeoutPolicy<HttpResponseMessage> Timeout(int secounds = 10)
        {
            return Policy.TimeoutAsync<HttpResponseMessage>(secounds, TimeoutStrategy.Optimistic);
        }

        public static AsyncRetryPolicy<HttpResponseMessage> RetryPolicy
        =>  HttpPolicyExtensions
                   .HandleTransientHttpError()
                   .Or<FlurlHttpException>()
                   .WaitAndRetryAsync(3, attempt => TimeSpan.FromSeconds(Math.Pow(2, attempt)));        
    }
}
