#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Asset.Variation.Api/Asset.Variations.Api.csproj", "src/Asset.Variation.Api/"]
COPY ["src/Asset.Services.Variation.Data/Asset.Variations.Data.csproj", "src/Asset.Services.Variation.Data/"]
COPY ["src/Asset.Variation.Domain/Asset.Variations.Domain.csproj", "src/Asset.Variation.Domain/"]
RUN dotnet restore "src/Asset.Variation.Api/Asset.Variations.Api.csproj"
COPY . .
WORKDIR "/src/src/Asset.Variation.Api"
RUN dotnet build "Asset.Variations.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Asset.Variations.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Asset.Variations.Api.dll"]