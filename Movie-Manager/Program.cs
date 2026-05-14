public class Program
{
    public static void Main(string[] args)
    {
        // Create a new MovieManager
        var MovieManager = new MovieManager();

        // Create a list of movies
        var movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", 1994, 9.3),
            new Movie("The Godfather", 1972, 9.2),
            new Movie("The Dark Knight", 2008, 9.0),
            new Movie("Pulp Fiction", 1994, 8.9),
            new Movie("Inception", 2010, 8.8),
        };

        // Add the movies to the MovieManager
        MovieManager.AddMovies(movies);
        MovieManager.printMovies();
    }

}
