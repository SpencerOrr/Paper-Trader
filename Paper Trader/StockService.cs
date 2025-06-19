using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class StockService
{
    private readonly string apiKey;

    public StockService(string apiKey)
    {
        this.apiKey = apiKey; // Save the API key in the class
    }



    public async Task<decimal> GetCurrentPriceAsync(string symbol)
    {
        using (HttpClient client = new HttpClient())
        {
            await Task.Delay(1000);
            string url = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={symbol}&apikey={apiKey}";
            var response = await client.GetStringAsync(url);
            JObject data = JObject.Parse(response);

            if (data["Global Quote"]?["05. price"] != null)
            {
                string priceStr = data["Global Quote"]["05. price"].ToString();
                if (decimal.TryParse(priceStr, out decimal price))
                {
                    return price;
                }
            }

            throw new Exception("Price not found for symbol: " + symbol);
        }
    }
}