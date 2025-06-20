using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Paper_Trader
{
    public partial class Trader : Form
    {
        private StockService stockService;
        private ChartService chartService;
        private List<StockPurchase> purchases;
        private const string PortolioData = "portfolio.xml";
        private decimal cash;
        private const string CashFile = "cash.txt";

        public Trader()
        {
            InitializeComponent();
            stockService = new StockService("d0rkvf1r01qumepesge0d0rkvf1r01qumepesgeg");
            chartService = new ChartService("d0rkvf1r01qumepesge0d0rkvf1r01qumepesgeg");
            cash = LoadCash();
            purchases = LoadPurchases();
            UpdateListBox();
        }
        private async void UpdateListBox()
        {
            lblcurrency.Text = $"Balance: ${cash}";
            lstPurchases.Items.Clear();
            await UpdatePortfolioValueAsync();
            foreach (var purchase in purchases)
            {
                lstPurchases.Items.Add(purchase.ToString());
            }
        }

        private decimal LoadCash()
        {
            if (File.Exists(CashFile))
                return decimal.Parse(File.ReadAllText(CashFile));
            return 1000;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePurchases();
        }

        private void SavePurchases()
        {
            var serializer = new XmlSerializer(typeof(List<StockPurchase>));
            using (var writer = new StreamWriter(PortolioData))
            {
                serializer.Serialize(writer, purchases);
            }
        }
        private void SaveCash()
        {
            File.WriteAllText(CashFile, cash.ToString());
        }
        private void ClearPurchases()
        {
            purchases.Clear();
            lstPurchases.Items.Clear();
            SavePurchases();
            MessageBox.Show("All purchases cleared.");
        }

        private List<StockPurchase> LoadPurchases()
        {
            if (File.Exists(PortolioData))
            {
                var serializer = new XmlSerializer(typeof(List<StockPurchase>));
                using (var reader = new StreamReader(PortolioData))
                {
                    return (List<StockPurchase>)serializer.Deserialize(reader);
                }
            }
            return new List<StockPurchase>();
        }

        private async void btnGetPrice_Click_1(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text.Trim().ToUpper();
            decimal price = await stockService.GetCurrentPriceAsync(symbol);
            lblPrice.Text = $"${price}";

        }

        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblPrice.Text.Replace("$", ""), out decimal price) && numQuantity.Value > 0 && !string.IsNullOrWhiteSpace(txtSymbol.Text))
            {
                int quantity = (int)numQuantity.Value;
                string symbol = txtSymbol.Text.Trim().ToUpper();
                if (cash - quantity * price > 0)
                {
                    var purchase = new StockPurchase(symbol, quantity, price);
                    purchases.Add(purchase);
                    cash -= quantity * price;
                    SaveCash();
                    UpdateListBox();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid stock symbol, quantity, and make sure the price is fetched.");
            }
        }

        private async void btnSavePortfolio_Click(object sender, EventArgs e)
        {
            await UpdatePortfolioValueAsync();
            SavePurchases();
        }
        private async Task UpdatePortfolioValueAsync()
        {
            decimal totalValue = 0;

            foreach (var purchase in purchases)
            {
                decimal currentPrice = await stockService.GetCurrentPriceAsync(purchase.Symbol);
                totalValue += currentPrice * purchase.Quantity;
            }

            lblPortfolioValue.Text = $"Portfolio Value: ${totalValue}";
            lblcurrency.Text = $"Cash: ${cash}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(symbol))
            {
                MessageBox.Show("Enter a stock symbol.");
                return;
            }

            try
            {
                var (candles, forms1Plot1) = await chartService.GetDailyCandlesAsync(symbol);
                chartService.PlotCandles(candles, formsPlot1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPurchases();
            cash = 1000;
            SaveCash();
            lblcurrency.Text = $"Balance: ${cash}";
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await UpdatePortfolioValueAsync();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblPrice.Text.Replace("$", ""), out decimal price) && numQuantity.Value > 0 && !string.IsNullOrWhiteSpace(txtSymbol.Text))
            {
                int qToSell = (int)numQuantity.Value;
                string symbol = txtSymbol.Text.Trim().ToUpper();

                var purchase = purchases.Find(p => p.Symbol == symbol);

                if (purchase != null)
                {
                    if (purchase.Quantity >= qToSell)
                    {
                        purchase.Quantity -= qToSell;
                        cash += qToSell * price;

                        if (purchase.Quantity == 0)
                            purchases.Remove(purchase);

                        SaveCash();
                        UpdateListBox();
                    }
                    else
                    {
                        MessageBox.Show("You don't own enough shares.");
                    }
                }
                else
                {
                    MessageBox.Show("You don't own any shares of this stock.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Make sure symbol, quantity, and price are correct.");
            }

        }
    }
}
