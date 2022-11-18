Console.Write("Enter a file name: ");
string filename = Console.ReadLine();

if(!string.IsNullOrEmpty(filename))
    filename += ".txt"; //  .txt is a globally accepted file format by most computer platforms

if(File.Exists(filename))
{
    Console.Write("Do you want to overwrite (y/n): ");
    string overwrite = Console.ReadLine();

    if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "y")
    {
        //  This means that the user wants to overwrite the file
        WriteToFile(filename);
    }
    else if(!string.IsNullOrEmpty(overwrite) && overwrite.ToLower() == "n")
    {
        //  This means that the user does not wish to overwrite the file
        Console.WriteLine("Did not overwrite file");

        Console.Write("Do you want to append to the file (y/n)? ");
        string append = Console.ReadLine();

        if(!string.IsNullOrEmpty(append) && append.ToLower() == "y")
        {
            AppendToFile(filename);
        }
        else if(!string.IsNullOrEmpty(append) && append.ToLower() == "n")
        {
            Console.WriteLine("Did not append to file");
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }
    else
    {
        //  This means that the user's response is not y or n
        //  Do nothing
        Console.WriteLine("Unknown choice");
    }
}
else
{
    WriteToFile(filename);
}

void WriteToFile(string filename)
{
    StreamWriter writer = new(filename);

    writer.Close();

    AppendToFile(filename);

    Console.WriteLine($"You are done writing to {filename}");
}

void AppendToFile(string filename)
{
    StreamWriter writer = File.AppendText(filename);

    Console.WriteLine("Enter the text that you wish to append to the file (enter x to exit)");

    while(true)
    {
        Console.Write(">>> ");

        string input = Console.ReadLine();

        if(!string.IsNullOrEmpty(input) && input.ToLower() == "x")
        {
            break;
        }

        writer.WriteLine(input);
    }

    writer.Close();
}