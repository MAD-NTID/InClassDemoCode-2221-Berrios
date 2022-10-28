namespace MovieLibraryCompleted_14;

public class MovieLibrary
{
    private readonly Movie?[] library;

    public int Length
    {
        get
        {
            int moviesNotNull = 0;

            foreach (var movie in library)
            {
                if(movie != null)
                    moviesNotNull ++;
            }

            return moviesNotNull;
        }
    }
    
    public MovieLibrary(int size)
    {
        if (size <= 0)
            size = 100;
        
        library = new Movie[size];
    }

    public void Add(Movie movie)
    {
        int index = Array.IndexOf(library, null);
        
        if(!movie.Equals(null))
            library[index] = movie;
    }

    public bool Remove(string? movieTitle)
    {
        Movie?[] tempLibrary = Library();
        
        foreach (var movie in tempLibrary)
        {
            if(movie != null && movieTitle != null && movie.Title.ToLower() == movieTitle.ToLower())
            {
                library[Array.IndexOf(library, movie)] = null;
                return true;
            }
        }

        return false;
    }

    public Movie? Find(string? movieTitle)
    {
        Movie?[] tempLibrary = Library();
        
        foreach (Movie movie in tempLibrary)
        {
            if(movie != null && movieTitle!= null && movie.Title.ToLower() == movieTitle.ToLower())
            {
                return movie;
            }
        }

        //  Alternatively, you can do this
        // for (int i = 0; i < tempLibrary.Length; i++)
        // {
        //     Movie movie = tempLibrary[i];
        //     
        //     if(movie != null && movieTitle!= null && movie.Title.ToLower() == movieTitle.ToLower())
        //     {
        //         return movie;
        //     }
        // }

        return null;
    }

    /// <summary>
    /// Library -
    /// This function will create a temporary library that contains only Movie objects that are not null from the library
    /// array object
    /// </summary>
    /// <returns>Movie[] tempLibrary</returns>
    public Movie[] Library()
    {
        Movie[] tempLibrary = new Movie[Length];
        int tempLibraryIndex = 0;

        foreach (Movie? movie in library)
        {
            if(movie == null)
                continue;
            
            tempLibrary[tempLibraryIndex] = movie;
            tempLibraryIndex ++;
        }

        return tempLibrary;
    }
}