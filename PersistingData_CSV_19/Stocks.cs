public class Stocks
{
    public const string FILEPATH = "mydata";
    public const string SEPARATOR = "|";

    private List<Stock> stocks;

    public Stocks()
    {
        stocks = new List<Stock>();
    }

    public void Add(Stock stock)
    {
        stocks.Add(stock);
    }

    public void Write()
    {
        using(StreamWriter writer = new(FILEPATH))
        {
            foreach(Stock stock in stocks)
                writer.WriteLine(stock);
        }
    }

    public List<Stock> Read()
    {
        //  Clear the List before recreating the objects
        stocks = new List<Stock>();

        using(StreamReader reader = new(FILEPATH))
        {
            while(!reader.EndOfStream)
            {
                string[] data = reader.ReadLine().Split(SEPARATOR);

                stocks.Add(new Stock(data[0], double.Parse(data[1])));
            }
        }

        return stocks;
    }
}