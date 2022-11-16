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

    Console.Write("What is your name? ");
    writer.WriteLine(Console.ReadLine());

    Console.Write("What is your age? ");
    writer.WriteLine(Console.ReadLine());

    writer.Close();

    Console.WriteLine($"You are done writing to {filename}");
}