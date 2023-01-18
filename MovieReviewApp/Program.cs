using Adapters;
using Application;
using Domain;

internal class Program
{
    private static void Main(string[] args)
    {
        IFetchMovieReviews fetchMovieReviews = new MovieReviewsRepo();
        IPrintMovieReviews printMovieReviews = new ConsolePrinter();
        IUserInput userCommand = new UserCommand(fetchMovieReviews, printMovieReviews);

        MovieUser movieUser = new MovieUser(userCommand);
        MovieSearchRequest starWarsRequest = new MovieSearchRequest("StarWars");
        MovieSearchRequest starTreckRequest = new MovieSearchRequest("StarTreck");

        Console.WriteLine("Displaying reviews for movie " + starTreckRequest.GetMovieName());
        movieUser.ProcessInput(starTreckRequest);
        Console.WriteLine("Displaying reviews for movie " + starWarsRequest.GetMovieName());
        movieUser.ProcessInput(starWarsRequest);
    }
}