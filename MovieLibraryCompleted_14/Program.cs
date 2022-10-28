using MovieLibraryCompleted_14;

const int LIBRARY_SIZE = 2;

MovieLibrary library = new(LIBRARY_SIZE);

while (true)
{
    Console.WriteLine(
        "Welcome to Movie Library!\n" + 
        "1. Add a New Movie to the Library (add)\n" +
        "2. Remove a Movie from the library (remove)\n" +
        "3. Find details of a Movie from the library (find)\n" +
        "4. Show the collection of Movies in the library (show)\n" +
        "5. Exit (exit)\n"
    );
    
    Console.Write("Enter a Choice: ");

    string? menuChoice = Console.ReadLine();

    menuChoice = !string.IsNullOrEmpty(menuChoice) ? menuChoice.ToLower() : null;
    
    if(menuChoice == "1" | menuChoice == "add")
    {
        if(library.Length < LIBRARY_SIZE)
        {
            var movie = new Movie();
            
            while (movie.TitleIsNotValid)
            {
                Console.Write("Enter a Title: ");

                movie.Title = Console.ReadLine();
                
                if(movie.TitleIsNotValid)
                    Console.WriteLine("Title is Required");
            }
    
            while (movie.DirectorIsNotValid)
            {
                Console.Write("Enter a Director: ");

                movie.Director = Console.ReadLine();
                
                if(movie.DirectorIsNotValid)
                    Console.WriteLine("Director is Required");
            }
            
            while (movie.GenreIsNotValid)
            {
                Console.Write("Enter a Genre: ");

                movie.Genre = Console.ReadLine();
                
                if(movie.GenreIsNotValid)
                    Console.WriteLine("Genre is Required");
            }
            
            while (movie.YearIsNotValid)
            {
                Console.Write("Enter the Year Released: ");
    
                if(int.TryParse(Console.ReadLine(), out int year))
                    movie.Year = year;
                
                if(movie.YearIsNotValid)
                    Console.WriteLine("Invalid Year Released");
            }
    
            while (movie.LengthIsNotValid)
            {
                Console.Write("Enter the Length of the Movie in Minutes: ");

                if(int.TryParse(Console.ReadLine(), out int length))
                    movie.Length = length;
                
                if(movie.LengthIsNotValid)
                    Console.WriteLine("Invalid Length in minutes for the Movie");
            }
            
            library.Add(movie);
            Console.WriteLine($"Movie '{movie.Title}' was added to the library");
        }
        else
            Console.WriteLine("Your movie library is full. Please remove a movie before adding a new one.");
    }
    else if(menuChoice == "2" | menuChoice == "remove")
    {
        if(library.Length > 0)
        {
            Console.WriteLine("Movie Titles in the Library\n");
        
            foreach (var movie in library.Library())
            {
                Console.WriteLine($"Title: {movie.Title}");
            }
        
            Console.Write("\nEnter a movie title to remove: ");

            string? movieTitle = Console.ReadLine();
            
            //  This is an example of ternary operator usage which is a shorthand for if / else
            Console.WriteLine(library.Remove(movieTitle) ? 
                $"Movie {movieTitle} has been removed from the library" :
                $"Failed to remove {movieTitle} from the library");
        }
        else
        {
            Console.WriteLine("There are no movie titles in the library. Please 'add' some.");
        }
    }
    else if(menuChoice == "3" | menuChoice == "find")
    {
        Console.Write("\nEnter a movie title to find: ");

        string? movieTitle = Console.ReadLine();
        
        Movie? movie = library.Find(movieTitle);
        
        if(movie != null)
        {
            Console.WriteLine($"Movie '{movie.Title}'\n" +
                              $"Director: {movie.Director}\n" +
                              $"Genre: {movie.Genre}\n" +
                              $"Year: {movie.Year} - Released: {movie.Age} years ago\n"+
                              $"Length: {movie.Length}");

            Console.Write("Press Enter to continue");
            Console.ReadLine();
        }
        else
            Console.WriteLine($"Failed to remove {movieTitle} from the library");
    }
    else if(menuChoice == "4" | menuChoice == "show")
    {
        if(library.Length > 0)
        {
            Console.WriteLine("Movie Titles in the Library\n");

            foreach (var movie in library.Library())
            {
                Console.WriteLine($"Movie '{movie.Title}'\n" +
                                  $"Director: {movie.Director}\n" +
                                  $"Genre: {movie.Genre}\n" +
                                  $"Year: {movie.Year} - Released: {movie.Age} years ago\n"+
                                  $"Length: {movie.Length}\n");
            }
            
            Console.Write("Press Enter to continue");
            Console.ReadLine();
        }
        else
            Console.WriteLine("There are no movie titles in the library. Please 'add' some.");
    }
    else if(menuChoice == "5")
    {
        Console.WriteLine("Please come back soon! Buh-bye!");
        break;
    }
    else
    {
        Console.WriteLine($"Invalid Menu Choice {menuChoice}");
    }
    
    //  New Loop Spacer
    Console.WriteLine();
}