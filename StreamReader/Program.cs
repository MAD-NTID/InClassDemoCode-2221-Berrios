Console.Write("Enter a file name: ");
string filename = Console.ReadLine();

if(!string.IsNullOrEmpty(filename))
    filename += ".txt"; //  .txt is a globally accepted file format by most computer platforms

if(File.Exists(filename))
{
    StreamReader reader = new(filename);

    //  Print the first line, and move to the next line
    // Console.WriteLine(
    //     reader.ReadLine()
    // );

    // Console.WriteLine(
    //     reader.ReadLine()
    // );

    // //  EndOfStream returns a bool of whether or not we are in the last line of the file
    // Console.WriteLine(
    //     reader.EndOfStream
    // );
    while(!reader.EndOfStream)
    {
        Console.WriteLine(
            reader.ReadLine()
        );
    }

    reader.Close();

    Console.WriteLine($"Done reading {filename}");
}
else
{
    Console.WriteLine($"File {filename} was not found");
}