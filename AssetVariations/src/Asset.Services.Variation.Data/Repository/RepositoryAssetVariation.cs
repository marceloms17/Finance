using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Asset.Variations.Data.Context;
using Asset.Variations.Data.Entities;
using Asset.Variations.Data.Interfaces;
using System.Drawing;
using System.Security.Cryptography;

namespace Asset.Variations.Data.Repository
{
    public class RepositoryAssetVariation : RepositoryBase<AssetVariation>, IAssetVariation
    {
        private readonly DbContextOptions<AssetVariationDbContext> _optionsBuilder;

        public RepositoryAssetVariation()
        {
            _optionsBuilder = new DbContextOptions<AssetVariationDbContext>();
        }

        public async Task<List<AssetVariation>> GetAssetVariationAsync()
        {

            using (var data = new AssetVariationDbContext(_optionsBuilder))
            {
                var queryAssetVariation = await (from GT in data.AssetVariation
                                             select new
                                             {

                                                 Id = GT.Id,
                                                 Dia = GT.Dia,
                                                 Data = GT.Data,
                                                 Valor = GT.Valor,
                                                 VariacaoDMenosUm = GT.VariacaoDMenosUm,
                                                 VariacaoDPrimeiraData = GT.VariacaoDPrimeiraData
                                             }).ToListAsync();
    
                var assetVariationList = queryAssetVariation.Select(a => new AssetVariation
                {                    
                    Dia = a.Dia,
                    Data = a.Data,
                    Valor = a.Valor,
                    VariacaoDMenosUm = a.VariacaoDMenosUm,
                    VariacaoDPrimeiraData = a.VariacaoDPrimeiraData
                }).ToList();

                return assetVariationList;
            }
        }
    }
}