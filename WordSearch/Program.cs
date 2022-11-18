Menu menu = new();

while(true)
{
    Console.WriteLine(menu);
    Console.Write("Choose Option: ");

    if(menu.MenuChoice(Console.ReadLine() ?? "", out int choice))
    {
        if(choice == 1)
        {
            CreateFile();
        }
        else if(choice == 2)
        {
            DeleteFile();
        }
        else if(choice == 3)
        {
            EditFile();
        }
        else if(choice == 4)
        {
            ReadFile();
        }
        else if(choice == 5)
        {
            SearchWord();
        }
        else
        {
            //  Ends Program Naturally
            Exit();
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }

    //  Blank Line Spacer
    Console.WriteLine();
}

void CreateFile()
{
    string filename;

    do
    {
        Console.Write("Enter a filename: ");

        filename = Console.ReadLine();

        if(string.IsNullOrEmpty(filename))
            Console.WriteLine("Invalid Filename");

        Console.WriteLine();
    } while(string.IsNullOrEmpty(filename));

    StreamWriter writer = new(filename);

    writer.Close();

    Console.WriteLine($"File {filename} has been created");
}

void DeleteFile()
{
    string filename;

    do
    {
        Console.Write("Enter the name of the file to delete: ");

        filename = Console.ReadLine() ?? "";

        if(!string.IsNullOrEmpty(filename) && File.Exists(filename))
        {
            File.Delete(filename);
            Console.WriteLine($"File {filename} has been deleted");
        }
        else
            Console.WriteLine($"File {filename} was not found");

        Console.WriteLine();
    } while(string.IsNullOrEmpty(filename));
}

void EditFile()
{
    string filename;

    do
    {
        Console.Write("Enter the name of the file to edit: ");

        filename = Console.ReadLine() ?? "";

        if(!string.IsNullOrEmpty(filename) && File.Exists(filename))
        {
            StreamWriter writer = File.AppendText(filename);

            Console.WriteLine("Enter the text that you wish to append to the file (enter x to exit)");

            while(true)
            {
                Console.Write(">>> ");

                string input = Console.ReadLine();

                if(!string.IsNullOrEmpty(input) && input.ToLower() == "x")
                    break;

                writer.WriteLine(input);
            }

            writer.Close();
        }
        else
            Console.WriteLine($"File {filename} was not found");

        Console.WriteLine();
    } while(string.IsNullOrEmpty(filename));
}

void ReadFile()
{
    string filename;

    do
    {
        Console.Write("Enter the name of the file to edit: ");

        filename = Console.ReadLine() ?? "";

        if(!string.IsNullOrEmpty(filename) && File.Exists(filename))
        {
            StreamReader reader = new(filename);

            while(!reader.EndOfStream)
            {
                Console.WriteLine(
                    reader.ReadLine()
                );
            }

            reader.Close();

            Console.WriteLine($"Done reading {filename}");
        }

        Console.WriteLine();
    } while(string.IsNullOrEmpty(filename));
}

void SearchWord()
{
    if(FindFile(out StreamReader file) && file != null)
    {
        while(true)
        {
            Console.Write("Enter the word to search: ");

            string word = Console.ReadLine() ?? "";

            if(!string.IsNullOrEmpty(word) && word.Split(" ").Length == 1)
            {
                int numberOfMatches = 0;

                while(!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    Console.WriteLine($"Seeking>>> {line}");

                    string[] line_words = line.ToLower().Split(word.ToLower());

                    int numberOfMatchesFoundForThisLine = line_words.Length > 0 ? 
                        line_words.Length - 1 : 0;

                    numberOfMatches += numberOfMatchesFoundForThisLine;

                    Console.WriteLine($"Matches found for this line: {numberOfMatchesFoundForThisLine}\n");

                    Thread.Sleep(1000);
                }

                file.Close();

                Console.WriteLine($"The word '{word}' was found {numberOfMatches} times");

                break;
            }
            else
            {
                Console.WriteLine("Enter 1 word only");
            }

            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("File was not found");
    }
}

bool FindFile(out StreamReader file)
{
    string filename;

    Console.Write("Enter the name of the file: ");

    filename = Console.ReadLine() ?? "";

    if(!string.IsNullOrEmpty(filename) && File.Exists(filename))
    {
        file = new(filename);
        return true;
    }

    Console.WriteLine();

    //  Means file not found
    file = null;
    return false;
}

void Exit()
{
    Console.WriteLine("Good bye!");
}