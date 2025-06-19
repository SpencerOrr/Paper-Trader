using System;

[Serializable]
public class StockPurchase
{
    public string Symbol { get; set; }
    public int Quantity { get; set; }
    public decimal PricePerShare { get; set; }

    public StockPurchase() { } 

    public StockPurchase(string symbol, int quantity, decimal pricePerShare)
    {
        Symbol = symbol;
        Quantity = quantity;
        PricePerShare = pricePerShare;
    }

    public override string ToString()
    {
        decimal total = Quantity * PricePerShare;
        return $"{Symbol} - {Quantity} shares @ ${PricePerShare} each (Total: ${total})";
    }
}
