using Newtonsoft.Json.Linq;
using ScottPlot;
using ScottPlot.Plottables; 
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

public class ChartService
{
    private readonly string apiKey;

    public ChartService(string apiKey)
    {
        this.apiKey = apiKey;
    }

    public async Task<(List<OHLC> candles, List<DateTime> dates)> GetDailyCandlesAsync(string symbol)
    {
        string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}";

        using (HttpClient client = new HttpClient())
        {
            string response = await client.GetStringAsync(url);
            JObject json = JObject.Parse(response);

            var series = json["Time Series (Daily)"];
            if (series == null)
                throw new Exception("Time Series data not found. Check the stock symbol or API key.");

            var candles = new List<OHLC>();
            var dates = new List<DateTime>();

            foreach (JProperty item in series.Children<JProperty>())
            {
                string dateStr = item.Name;
                DateTime date = DateTime.Parse(dateStr);
                JObject dayData = (JObject)item.Value;

                double open = double.Parse(dayData["1. open"].ToString());
                double high = double.Parse(dayData["2. high"].ToString());
                double low = double.Parse(dayData["3. low"].ToString());
                double close = double.Parse(dayData["4. close"].ToString());

                candles.Add(new OHLC(open, high, low, close, date, TimeSpan.Zero));
                dates.Add(date);
            }

            // Reverse so it's oldest to newest
            candles.Reverse();
            dates.Reverse();

            return (candles, dates);
        }
    }

    public void PlotCandles(List<OHLC> candles, FormsPlot plot)
    {
        plot.Plot.Clear();
        plot.Plot.Add.Candlestick(candles.ToArray());
        plot.Plot.Axes.DateTimeTicksBottom(); 
        plot.Refresh();
    }
}