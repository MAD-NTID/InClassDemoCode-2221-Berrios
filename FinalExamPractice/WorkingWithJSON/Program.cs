using Newtonsoft.Json;

string[] menu = {
    "Create new sales",
    "Remove a record",
    "Show all sale records",
    "Write records to file",
    "Read in sales from file",
    "Exit"
};

List<GameSale> gameSales = new();

// gameSales.Add(
//     new GameSale("Mario Kart", "Wii", "January 1 2020", 500000, 15000000)
// );

// gameSales.Add(
//     new GameSale("Mario Kart 2", "Switch", "January 1 2022", 1000000, 25000000)
// );

while(true)
{
    PrintMenu();

    Console.Write("Enter Choice: ");
    string input = Console.ReadLine();

    if(input == "1")
    {
        CreateNewSale();
    }
    else if(input == "2")
    {
        RemoveARecord();
    }
    else if(input == "3")
    {
        ShowAllSales();
    }
    else if(input == "4")
    {
        WriteRecordsToFile();
    }
    else if(input == "5")
    {
        ReadRecordsToList();
    }
    else if(input == "6")
    {
        Console.WriteLine("Thank you message here.... bye bye");
        break;
    }
    else 
    {
        Console.WriteLine("Invalid Choice");
    }

    //  A line spacer for every time we loop - for clarity purposes
    Console.WriteLine();
}

void PrintMenu()
{
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menu[i]}");
    }
}

void CreateNewSale()
{
    Console.Write("Enter the name of the game: ");
    string name = Console.ReadLine();

    Console.Write("Enter the platform: ");
    string platform = Console.ReadLine();

    Console.Write("Enter the date of the sale: ");
    string date = Console.ReadLine();

    Console.Write("Total Copies Sold: ");
    int totalCopiesSold = int.Parse(Console.ReadLine());

    Console.Write("Total Revenue: ");
    double totalRevenue = double.Parse(Console.ReadLine());

    gameSales.Add(
        new GameSale(name, platform, date, totalCopiesSold, totalRevenue)
    );

    Console.WriteLine($"Game {gameSales.Last().Name} has been added to the Game Sales List");
}

void ShowAllSales()
{
    if(gameSales.Count > 0)
    {
        Console.WriteLine(
            $"{"Name", GameSale.JUSTIFY}" +
            $"{"Platform", GameSale.JUSTIFY}" +
            $"{"Date", GameSale.JUSTIFY}" +
            $"{"Total Copies Sold", GameSale.JUSTIFY}" +
            $"{"Total Revenue", GameSale.JUSTIFY}"
        );

        foreach(GameSale gameSale in gameSales)
        {
            Console.WriteLine(gameSale);
        }

        Console.WriteLine($"==> {gameSales.Count} records displayed");
    }
    else
    {
        Console.WriteLine($"==> No Game Records to Display");
    }
}

void RemoveARecord()
{
    Console.Write("Enter the name of the game: ");
    string name = Console.ReadLine().ToLower();

    Console.Write("Enter the platform: ");
    string platform = Console.ReadLine().ToLower();

    bool found = false;

    foreach(GameSale gameSale in gameSales)
    {
        if(gameSale.Name.ToLower().Equals(name) && gameSale.Platform.ToLower().Equals(platform))
        {
            gameSales.Remove(gameSale);
            found = true;
            break;
        }
    }

    if(found)
        Console.WriteLine("Game was removed");
    else
        Console.WriteLine("Game was not found");
}

void WriteRecordsToFile()
{
    string filename;

    while(true)
    {
        Console.Write("Enter the name of the file to save (must end with .json): ");
        filename = Console.ReadLine();       

        if(!filename.EndsWith(".json"))
            Console.WriteLine("Invalid File. THe filename must end with .json");
        else
            break;
    }

    StreamWriter writer = new(filename);

    writer.WriteLine(JsonConvert.SerializeObject(gameSales));

    Console.WriteLine($"Records has been written to file {filename}");

    writer.Close();

    // using(StreamWriter writer = new(filename))
    // {
    //     writer.WriteLine("name,platform,date,totalCopiesSold,totalRevenue");

    //     foreach(GameSale gameSale in gameSales)
    //     {
    //         writer.WriteLine($"{gameSale.Name},{gameSale.Platform},{gameSale.Date},{gameSale.TotalCopiesSold},{gameSale.TotalRevenue}");
    //     }

    //     Console.WriteLine($"Records has been written to file {filename}");
    // }
}

void ReadRecordsToList()
{
    string filename;

    while(true)
    {
        Console.Write("Enter the name of the file to load (must end with .json): ");
        filename = Console.ReadLine();       

        if(!filename.EndsWith(".json"))
            Console.WriteLine("Invalid File. The filename must end with .json");
        else
            break;
    }

    using(StreamReader reader = new(filename))
    {
        gameSales = JsonConvert.DeserializeObject<List<GameSale>>(reader.ReadToEnd());

        if(gameSales.Count > 0)
            Console.WriteLine("Game sales were successfully loaded");
        else
            Console.WriteLine("No game sales were loaded");
    }
}