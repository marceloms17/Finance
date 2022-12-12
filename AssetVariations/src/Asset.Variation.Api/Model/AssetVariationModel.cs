using Newtonsoft.Json;

namespace Asset.Variations.Api.Model
{
    public class AssetVariationModel
    {

        public int GruCodigo { get; set; }

        public string Descricao { get; set; } = null!;

        public bool? GruExibeBusca { get; set; }

        public string? GruTexto { get; set; }

        public int? OrdemExibicao { get; set; } 

    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Chart
    {
        [JsonProperty("result")]
        public List<Result> Result;

        [JsonProperty("error")]
        public object Error;
    }

    public class CurrentTradingPeriod
    {
        [JsonProperty("pre")]
        public Pre Pre;

        [JsonProperty("regular")]
        public Regular Regular;

        [JsonProperty("post")]
        public Post Post;
    }

    public class Indicators
    {
        [JsonProperty("quote")]
        public List<Quote> Quote;
    }

    public class Meta
    {
        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("symbol")]
        public string Symbol;

        [JsonProperty("exchangeName")]
        public string ExchangeName;

        [JsonProperty("instrumentType")]
        public string InstrumentType;

        [JsonProperty("firstTradeDate")]
        public int FirstTradeDate;

        [JsonProperty("regularMarketTime")]
        public int RegularMarketTime;

        [JsonProperty("gmtoffset")]
        public int Gmtoffset;

        [JsonProperty("timezone")]
        public string Timezone;

        [JsonProperty("exchangeTimezoneName")]
        public string ExchangeTimezoneName;

        [JsonProperty("regularMarketPrice")]
        public double RegularMarketPrice;

        [JsonProperty("chartPreviousClose")]
        public double ChartPreviousClose;

        [JsonProperty("previousClose")]
        public double PreviousClose;

        [JsonProperty("scale")]
        public int Scale;

        [JsonProperty("priceHint")]
        public int PriceHint;

        [JsonProperty("currentTradingPeriod")]
        public CurrentTradingPeriod CurrentTradingPeriod;

        //[JsonProperty("tradingPeriods")]
        //public List<List<>> TradingPeriods;

        [JsonProperty("dataGranularity")]
        public string DataGranularity;

        [JsonProperty("range")]
        public string Range;

        [JsonProperty("validRanges")]
        public List<string> ValidRanges;
    }

    public class Post
    {
        [JsonProperty("timezone")]
        public string Timezone;

        [JsonProperty("start")]
        public int Start;

        [JsonProperty("end")]
        public int End;

        [JsonProperty("gmtoffset")]
        public int Gmtoffset;
    }

    public class Pre
    {
        [JsonProperty("timezone")]
        public string Timezone;

        [JsonProperty("start")]
        public int Start;

        [JsonProperty("end")]
        public int End;

        [JsonProperty("gmtoffset")]
        public int Gmtoffset;
    }

    public class Quote
    {
        [JsonProperty("low")]
        public List<double?> Low;

        [JsonProperty("volume")]
        public List<int?> Volume;

        [JsonProperty("close")]
        public List<double?> Close;

        [JsonProperty("open")]
        public List<double?> Open;

        [JsonProperty("high")]
        public List<double?> High;
    }

    public class Regular
    {
        [JsonProperty("timezone")]
        public string Timezone;

        [JsonProperty("start")]
        public int Start;

        [JsonProperty("end")]
        public int End;

        [JsonProperty("gmtoffset")]
        public int Gmtoffset;
    }

    public class Result
    {
        [JsonProperty("meta")]
        public Meta Meta;

        [JsonProperty("timestamp")]
        public List<int> Timestamp;

        [JsonProperty("indicators")]
        public Indicators Indicators;
    }

    public class Root
    {
        [JsonProperty("chart")]
        public Chart Chart;
    }


}
