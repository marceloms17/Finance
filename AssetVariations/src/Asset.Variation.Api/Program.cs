using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Asset.Variations.Data.Context;
using Asset.Variations.Data.Entities;
using Asset.Variations.Data.Interfaces;
using Asset.Variations.Data.Repository;
using Asset.Variations.Api.Model;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHealthChecks();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "AssetVariation Web API", Version = "v1" });
});

builder.Services.AddDbContext<AssetVariationDbContext>
    (options => options.UseInMemoryDatabase("AssetVariationDb"));

builder.Services.AddSingleton(typeof(IBase<>), typeof(RepositoryBase<>));
builder.Services.AddSingleton<IAssetVariation, RepositoryAssetVariation>();

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<AssetVariationModel, AssetVariation>();
    cfg.CreateMap<AssetVariation,AssetVariationModel>();

});
IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);   

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
if (app.Environment.IsDevelopment())
{
    app.UsePathBase("/Asset.Variations.Api");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHealthChecks("/check");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
