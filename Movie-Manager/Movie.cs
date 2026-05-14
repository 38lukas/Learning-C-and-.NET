public class Movie(string title, int year, double rating)
{
    public string Title { get; set; } = title;
    public int Year { get; set; } = year;
    public double Rating { get; set; } = rating < 0 || rating > 10 ? 0 : rating; // Default value if rating is not between 0 and 10
}
