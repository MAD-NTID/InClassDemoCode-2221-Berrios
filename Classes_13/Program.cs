Movie movie_1 = new Movie(
    "",
    "Joseph McEnroe",
    "Comedy | Horror | Romance",
    1800,
    -50
);

Console.WriteLine($"Title Before Modifying: {movie_1.Title}");

// movie_1.title = "A New Title";
//movie_1.ChangeMovieTitle("Johnny and the 12 Dwarfs"); // the old way, with the method, no longer needed now, look below for new way
movie_1.Title = "Johnny and the 12 Dwarfs"; //  this calls the setter methdo of the property 'Title'

Console.WriteLine($"Title After Modifying: {movie_1.Title}");   //  this calls the getter method of the property 'Title'

Console.WriteLine($"The movie was released in {movie_1.Year} and it is {movie_1.Age} years old");

Console.WriteLine($"The movie is {movie_1.TimeRun} minutes long");