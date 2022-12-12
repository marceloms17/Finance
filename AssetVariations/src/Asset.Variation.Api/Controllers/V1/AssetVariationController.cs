using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Asset.Variations.Data.Interfaces;
using Asset.Variations.Api.Model;
using Newtonsoft.Json;
using Asset.Variations.Domain.Acl;

namespace Asset.Variations.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetVariationController : ControllerBase
    {
        public readonly IAssetVariation _IAssetVariation;
        public readonly IMapper _IMapper;
        public readonly IFinanceAcl _acl;

        public AssetVariationController(IAssetVariation IAssetVariation, IMapper IMapper, IFinanceAcl acl)
        {
            _IAssetVariation = IAssetVariation;
            _IMapper = IMapper;
            _acl = acl;
        }

        [HttpGet("/GetAssetVariations")]
        public async Task<List<AssetVariationModel>> AssetVariations()
        {

            //TODO-- REMOVER ESSE CODIGO DAQUI E LEVAR PARA A SERVICE

            //string url = "https://query2.finance.yahoo.com/v8/finance/chart/PETR4.SA";

            //HttpClient httpClient = new HttpClient();
            //try
            //{
            //    _acl.GetFinanceAsync();
            //    var httpResponseMessage = await httpClient.GetAsync(url);

            //    string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

            //    var AssetVariations = JsonConvert.DeserializeObject<AssetVariationModel>(jsonResponse);

            //    return null;

            //}
            //catch (Exception)
            //{

            //    throw;
            //}


            var assetVariation = await _IAssetVariation.GetAssetVariationAsync();
            var clientMap = _IMapper.Map<IEnumerable<AssetVariationModel>>(assetVariation);
            //return clientMap;
            return null;
        }
    }
}