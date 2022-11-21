public class Stock
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    
    public Stock(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name}{Stocks.SEPARATOR}{Price}";
    }
}