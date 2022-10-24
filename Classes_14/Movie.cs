public class Movie
{
    private string title, director, genre;
    private int year, timerun;

    public const int MOVIE_YEAR_VALIDATION = 1888;

    //  Validate the Movie title
    public string Title 
    {
        //  Setter
        set {
            //  this is the variable that handles the value passed into the property, it's always called 'value'
            // value
            if(value != null && value != "")
            {
                title = value;
            }
        }

        //  Getter
        get {
            if(title == null || title == "")
                return "Movie Title Not Assigned";  //  HINT: if you only have online of code after if statement, no curly braces are needed

            return title;
        }
    }

    //  This property returns whether the title is bad or good
    public bool TitleIsValid
    {
        get {
            if(title == null || title == "")
                return false;

            return true;
        }
    }

    //  Validate the Director
    public string Director
    {
        set {
            if(value != null && value != "")
                director = value;
        }

        get {
            if(director == null || director == "")
                return "Director Not Assigned";

            return director;
        }
    }

    public bool DirectorIsValid
    {
        get {
            if(director == null || director == "")
                return false;

            return true;
        }
    }

    //  Validate the Genre
    public string Genre
    {
        set {
            if(value != null && value != "")
                genre = value;
        }

        get {
            if(genre == null || genre == "")
                return "Genre Not Assigned";

            return genre;
        }
    }

    public bool GenreIsValid
    {
        get {
            if(genre == null || genre == "")
                return false;

            return true;
        }
    }

    //  Validate the Year
    public int Year
    {
        set {
            if(value >= MOVIE_YEAR_VALIDATION && value <= DateTime.Now.Year)
                year = value;
            else
                year = MOVIE_YEAR_VALIDATION;
        }

        get {
            return year;
        }
    }

    public bool YearIsValid
    {
        get {
            return year >= MOVIE_YEAR_VALIDATION;                
        }
    }

    //  Validate the TimeRun
    public int TimeRun
    {
        set {
            if(value > 0)
                timerun = value;
            else
                value = 0;
        }

        get {
            return timerun;
        }
    }

    //  Get the Age of the movie
    public int Age 
    {
        get {
            return DateTime.Now.Year - Year;
        }
    }

    public Movie() {}

    public Movie(string title, string director, string genre, int year, int timerun)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Year = year;
        TimeRun = timerun;
    }
}