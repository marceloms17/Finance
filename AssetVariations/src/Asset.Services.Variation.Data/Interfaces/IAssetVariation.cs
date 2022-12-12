using Asset.Variations.Data.Entities;

namespace Asset.Variations.Data.Interfaces
{
    public interface IAssetVariation : IBase<AssetVariation>
    {
        Task<List<AssetVariation>> GetAssetVariationAsync();
    }
}