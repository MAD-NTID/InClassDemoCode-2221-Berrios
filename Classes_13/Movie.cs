public class Movie
{
    private string title, director, genre;
    private int year, timerun;

    private const int MOVIE_YEAR_VALIDATION = 1888;

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

    public Movie(string title, string director, string genre, int year, int timerun)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Year = year;
        TimeRun = timerun;
    }
}