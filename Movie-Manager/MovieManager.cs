public class MovieManager
{
    public List<Movie> Movies { get; set; } = new List<Movie>();

    // Add a movie to the list
    public void AddMovie(Movie movie){
        Movies.Add(movie);
    }

    // Add a list of movies to the list
    public void AddMovies(List<Movie> movies){
        Movies.AddRange(movies);
    }

    // Print the movies in the list
    public void printMovies(){
        foreach (var movie in Movies){
            Console.WriteLine($"Title: {movie.Title}\nYear: {movie.Year}\nRating: {movie.Rating}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Print a single movie
    public void printMovie(Movie movie){
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Title: {movie.Title}\nYear: {movie.Year}\nRating: {movie.Rating}");
        Console.WriteLine("--------------------------------");
    }

    // Find a movie by title
    public Movie? findMovieByTitle(string title){
        foreach (var movie in Movies){
            if (movie.Title == title){
                return movie;
            }
        }
        Console.WriteLine("Movie not found");
        return null;
    }
}