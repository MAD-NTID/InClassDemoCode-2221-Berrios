string[] menu = {"Create Stock", "Load Saved Stocks", "Save", "Exit"};
Stocks stocks = new Stocks();

bool continueApp = true;

while(continueApp)
{
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menu[i]}");
    }

    Console.Write("Choose: ");

    switch(Console.ReadLine())
    {
        case "1":
            CreateStock();
        break;

        case "2":
            LoadSavedStocks();
        break;

        case "3":
            Save();
        break;

        case "4":
            Console.WriteLine("Good bye");
            continueApp = false;
        break;

        default:
            Console.WriteLine("Unknown Option");
        break;
    }

    Console.WriteLine();
}

void CreateStock()
{
    Console.Write("Enter Stock Name: ");
    string name = Console.ReadLine() ?? "No Name";

    Console.Write("Enter the Stock Price: ");
    double price = double.Parse(Console.ReadLine() ?? "0");

    stocks.Add(new Stock(name, price));

    Console.WriteLine($"Your stock '{name}' for {price:C} has been created");
}

void LoadSavedStocks()
{
    stocks.Read();

    Console.WriteLine($"Stocks has been loaded: ");

    foreach(Stock stock in stocks.Read())
        Console.WriteLine(stock);
}

void Save()
{
    stocks.Write();

    Console.WriteLine("Stocks has been saved");
}