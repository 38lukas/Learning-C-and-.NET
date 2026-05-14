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
}