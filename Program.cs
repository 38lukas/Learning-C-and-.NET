public class Program
{
    public static void Main(string[] args)
    {
        var movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3 },
            new Movie { Title = "The Godfather", Year = 1972, Rating = 9.2 },
            new Movie { Title = "The Dark Knight", Year = 2008, Rating = 9.0 },
            new Movie { Title = "Pulp Fiction", Year = 1994, Rating = 8.9 },
            new Movie { Title = "Inception", Year = 2010, Rating = 8.8 },
        };
    }
}
