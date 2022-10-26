const string BUSINESS_NAME = "PF1 Movie Library";

Console.WriteLine($"*** Welcome to {BUSINESS_NAME} ***");

int movieCounts;

while(true)
{
    Console.Write("How many movies do you want in your library? ");

    if(int.TryParse(Console.ReadLine(), out movieCounts) && movieCounts > 0)
        break;
    else
        Console.WriteLine("Invalid number of movies entered\n");
}

//  Create the library
Movie[] movies = new Movie[movieCounts];

//  Create a Pre-Set Library, just to test other menu options
movies[0] = new Movie("Cinderalla", "McEnroe", "Toon", 1990, 90);
movies[1] = new Movie("Alvin and the Chipmunk", "Quinn", "Comedy", 2006, 120);

while(true)
{
    Console.WriteLine("What would you like to do? \n\n" +
    "1. Add a New Movie\n" +
    "2. Delete a Movie from Library\n" +
    "3. Edit a Movie\n" + 
    "4. Find a Movie\n" + 
    "5. Show Movies\n" + 
    "6. Exit");

    string menuInput = Console.ReadLine().ToLower();

    //  Validate the user's choice
    if(menuInput == "1" || menuInput == "add")
    {
        Console.Write("Add All of the Movies to the Library First\n");

        for(int i = 0; i < movies.Length; i++)
        {
            //  Make sure you do not delete the existing movie
            if(movies[i] != null)
            {
                Console.WriteLine($"Enter Details for Movie #{i + 1}");

                Movie newMovie = new Movie();

                //  Small Validation to check if the movie title is null or empty
                while(true)
                {
                    Console.Write("Enter Movie Title: ");

                    newMovie.Title = Console.ReadLine();

                    //  If the movie name entered does not match 'Movie Title Not Assigned'
                    //  Then this means that the title is valid, so break out of 
                    //  the Title loop
                    if(newMovie.TitleIsValid)
                        break;

                    Console.WriteLine("Invalid Movie Title\n");
                }

                //  Gets the Director
                while(true)
                {
                    Console.Write("Enter Movie Director: ");

                    newMovie.Director = Console.ReadLine();

                    if(newMovie.DirectorIsValid)
                        break;

                    Console.WriteLine("Invalid Movie Director\n");
                }

                //  Gets the Genre
                while(true)
                {
                    Console.Write("Enter Movie Genre: ");

                    newMovie.Genre = Console.ReadLine();

                    if(newMovie.GenreIsValid)
                        break;

                    Console.WriteLine("Invalid Movie Genre\n");
                }

                //  Gets the Year
                while(true)
                {
                    Console.Write("Enter Movie Year: ");

                    //  Validate first that input is a number
                    if(int.TryParse(Console.ReadLine(), out int year))
                    {
                        newMovie.Year = year;

                        //  Validate that year satisfied Movie year requirement
                        if(newMovie.YearIsValid)
                            break;
                        else
                        {
                            Console.WriteLine("Sorry, you are not allowed to put that year\n" +
                            $"Year must be equal to or greater than {Movie.MOVIE_YEAR_VALIDATION}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Movie Year");
                    }
                }

                //  Gets the TimeRun
                while(true)
                {
                    Console.Write("Enter the Timerun: ");

                    //  Validate first that input is a number
                    if(int.TryParse(Console.ReadLine(), out int timerun))
                    {
                        newMovie.TimeRun = timerun;

                        //  Validate that year satisfied Movie year requirement
                        if(newMovie.TimeRunIsValid)
                            break;
                        else
                        {
                            Console.WriteLine("Sorry, you are not allowed to put that timerun. \nPlease enter a time run greater than 0 minutes");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Timerun");
                    }
                }

                //  Finally, add the movie object to the array
                movies[i] = newMovie;
            }
        }
    }
    else if(menuInput == "2" || menuInput == "delete")
    {
        for(int i = 0; i < movies.Length; i++)
        {
            //  Check that the index in the movies array is not null
            if(movies[i] != null) 
            {
                Console.WriteLine($"Movie Details for Movie #{i + 1}");
                Console.WriteLine(
                    $"Name: {movies[i].Title}\n" + 
                    $"Year: {movies[i].Year}\n"
                );
            }
        }

        while(true) 
        {
            Console.Write("Enter the movie name that you would like to delete: ");

            string movieName = Console.ReadLine();
            bool movieFound = false;

            for(int i = 0; i < movies.Length; i++)
            {
                //  Check that the index in the movies array is not null
                if(movies[i] != null && movies[i].Title == movieName) 
                {
                    movies[i] = null;

                    movieFound = true;

                    break;
                }
            }

            if(movieFound)
            {
                Console.WriteLine($"Movie '{movieName}' has been deleted");
                break;   
            }
            else
                Console.WriteLine($"Movie '{movieName}' was not found");
        }
    }
    else if(menuInput == "3" || menuInput == "edit")
    {

    }
    else if(menuInput == "4" || menuInput == "find")
    {

    }
    else if(menuInput == "5" || menuInput == "show")
    {
        bool hasMovie = false;

        for(int i = 0; i < movies.Length; i++)
        {
            //  Check that the index in the movies array is not null
            
                Console.WriteLine($"Movie Details for Movie #{i + 1}");
                Console.WriteLine(
                    $"Name: {movies[i].Title}\n" + 
                    $"Year: {movies[i].Year}\n"
                );

                hasMovie = true;
            
        }

        if(!hasMovie)
        {
            Console.WriteLine("There are no movies available");
        }
    }
    else if(menuInput == "6" || menuInput == "exit")
    {
        Console.WriteLine($"Thank you for using {BUSINESS_NAME}. Buh-Bye!");
        break;
    }
    else
    {
        Console.WriteLine("Sorry, that's an invalid menu choice");
    }
}