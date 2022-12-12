using System;
using System.Collections.Generic;
namespace Asset.Variations.Data.Entities;

public partial class AssetVariation
{
    public int Id { get; set; }

    public int Dia { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor { get; set; }

    public float VariacaoDMenosUm { get; set; }

    public float VariacaoDPrimeiraData { get; set; }

}
