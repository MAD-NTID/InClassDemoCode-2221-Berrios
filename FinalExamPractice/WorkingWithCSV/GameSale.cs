public class GameSale
{
    const string DEFAULT_NAME = "Name not provided";
    const string DEFAULT_PLATFORM = "Platform not provided";
    const string DEFAULT_DATE = "Date not provided";

    public const int JUSTIFY = -20;

    private string name;
    public string Name
    {
        get { return name; }
        set { 
            // if(string.IsNullOrEmpty(value))
            //     name = DEFAULT_NAME;
            // else
            //     name = value; 

            name = string.IsNullOrEmpty(value) ? DEFAULT_NAME : value;
        }
    }
    
    private string date;
    public string Date
    {
        get { return date; }
        set { 
            if(DateTime.TryParse(value, out DateTime parsedDate))
                date = value;
            else
                date = DEFAULT_DATE;
        }
    }
    
    private string platform;
    public string Platform
    {
        get { return platform; }
        set { 
            platform = string.IsNullOrEmpty(value) ? DEFAULT_PLATFORM : value;
        }
    }
    
    private int totalCopiesSold;
    public int TotalCopiesSold
    {
        get { return totalCopiesSold; }
        set { 
            if(value >= 0)
                totalCopiesSold = value;
        }
    }
    
    private double totalRevenue;
    public double TotalRevenue
    {
        get { return totalRevenue; }
        set { 
            if(value >= 0)
                totalRevenue = value;
        }
    }

    public GameSale()
    {
        name = DEFAULT_NAME;
        platform = DEFAULT_PLATFORM;
        date = DEFAULT_DATE;
        totalCopiesSold = 0;
        totalRevenue = 0;
    }
    
    public GameSale(string name, string platform, string date, int totalCopiesSold, double totalRevenue)
    {
        Name = name;
        Platform = platform;
        Date = date;
        TotalCopiesSold = totalCopiesSold;
        TotalRevenue = totalRevenue;
    }

    public override string ToString()
    {
        return $"{Name, JUSTIFY}{Platform, JUSTIFY}{Date, JUSTIFY}{TotalCopiesSold, JUSTIFY}{TotalRevenue, JUSTIFY:C}";
    }
}