using Microsoft.EntityFrameworkCore;
using Asset.Variations.Data.Models;
using Microsoft.Extensions.Configuration;

namespace Asset.Variations.Data.Context;

public partial class AssetVariationDbContext : DbContext
{
    public AssetVariationDbContext()
    {
    }

    public AssetVariationDbContext(DbContextOptions<AssetVariationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssetVariation> AssetVariation { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer(DbConnectionString);


    private static string _dbConnectionString;



    private static string DbConnectionString 
    {
        get 
        {
            if (string.IsNullOrWhiteSpace(_dbConnectionString))
            {
                var config = new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Environment.CurrentDirectory, "appsettings.json")).Build();
                _dbConnectionString = config.GetSection(key: "ConnectionStrings")["AssetVariationConnection"];
            }

            return _dbConnectionString;
        }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AI");

        modelBuilder.Entity<AssetVariation>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("AssetVariation");

            entity.Property(e => e.Dia).HasColumnName("Dia");
            entity.Property(e => e.Data).HasColumnName("Data");
            entity.Property(e => e.Valor).HasColumnName("Valor");
            entity.Property(e => e.VariacaoDMenosUm).HasColumnName("VariacaoDMenosUm");
            entity.Property(e => e.VariacaoDPrimeiraData).HasColumnName("VariacaoDPrimeiraData");
        });    

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
