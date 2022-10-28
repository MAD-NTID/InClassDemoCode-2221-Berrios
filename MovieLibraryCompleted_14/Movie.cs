namespace MovieLibraryCompleted_14;

public class Movie
{
    private string? title, director, genre;
    private int year, length;

    private const int MOVIE_YEAR_VALIDATION = 1888;

    //  Validate the Movie title
    public string Title 
    {
        //  Setter
        set 
        {
            if(!string.IsNullOrEmpty(value))
                title = value;
        }

        //  Getter
        get
        {
            if(!string.IsNullOrEmpty(title))
                return title;

            return "Title is not Specified";
        }
    }

    //  This property returns whether the title is bad or good
    public bool TitleIsNotValid
    {
        get
        {
            return string.IsNullOrEmpty(title);
        }
    }

    //  Validate the Director
    public string? Director
    {
        set 
        {
            if(!string.IsNullOrEmpty(value))
                director = value;
        }

        get 
        {
            //  This is called a Ternary Operator which is a shorthand version of if / else statement
            return !string.IsNullOrEmpty(director) ?
                    director : "Director is not Defined";
        }
    }

    public bool DirectorIsNotValid
    {
        get
        {
            return string.IsNullOrEmpty(director);
        }
    }

    //  Validate the Genre
    public string? Genre
    {
        set 
        {
            if(!string.IsNullOrEmpty(value))
                genre = value;
        }

        get 
        {
            return !string.IsNullOrEmpty(genre) ? 
                genre : "Genre is not Defined";
        }
    }

    public bool GenreIsNotValid
    {
        get
        {
            return string.IsNullOrEmpty(genre);
        }
    }

    //  Validate the Year
    public int Year
    {
        set 
        {
            if(value >= MOVIE_YEAR_VALIDATION && value <= DateTime.Now.Year)
                year = value;
        }

        get 
        {
            return year;
        }
    }

    public bool YearIsNotValid
    {
        get 
        {
            return year < MOVIE_YEAR_VALIDATION;                
        }
    }

    //  Validate the TimeRun
    public int Length
    {
        set
        {
            length = value > 0 ? value : 0;
        }

        get 
        {
            return length;
        }
    }

    public bool LengthIsNotValid
    {
        get 
        {
            return length <= 0;
        }
    }

    public static int MinimumYearAllowed
    {
        get
        {
            return MOVIE_YEAR_VALIDATION;
        }
    }
    
    //  Get the Age of the movie
    public int Age 
    {
        get 
        {
            return DateTime.Now.Year - Year;
        }
    }
    
    public Movie() {}

    public Movie(string title, string director, string genre, int year, int length)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Year = year;
        Length = length;
    }
}