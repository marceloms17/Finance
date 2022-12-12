using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Variations.Infra.Configuration.Extensions
{
    public static class HttpMessageExtensions
    {
        public static async Task<TValue> ReadJson<TValue>(this HttpResponseMessage response, JsonSerializer serializer = null) where TValue : class
        {
            if (response.Content is null)
            {
                return null;
            }

            using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
            using StreamReader reader = new StreamReader(stream);
            using JsonTextReader jsonReader = new JsonTextReader(reader);
            try
            {
                return (serializer ?? JsonSerializer.CreateDefault()).Deserialize<TValue>(jsonReader);
            }
            catch (JsonReaderException)
            {
                return null;
            }
        }

        public static async Task<TValue> ReceiveResult<TValue>(this Task<HttpResponseMessage> response, Func<HttpResponseMessage, Task<TValue>> resultFactory)
        {
            using HttpResponseMessage message = await response.ConfigureAwait(continueOnCapturedContext: false);
            return await resultFactory(message);

        }

        public static async Task<TValue> ReceiveResult<TValue>(this Task<HttpResponseMessage> response, JsonSerializer serializer = null) where TValue : class
        {
            return await response.ReceiveResult(async delegate (HttpResponseMessage message)
            {
                switch ((int)message.StatusCode / 100)
                {
                    case 1:
                    case 2:
                    case 3:
                        {
                            TValue value = await message.ReadJson<TValue>(serializer);
                            return value;
                        }
                    default:
                        throw new InvalidOperationException("unknow HTTP");
                }
            });

        }
    }
}
