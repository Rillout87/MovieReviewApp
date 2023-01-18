using Domain;
using Application;

namespace Adapters
{
    internal class ConsolePrinter : IPrintMovieReviews
    {

        public void WriteMovieReviews(List<MovieReview> movieReviewList)
        {
            movieReviewList.ForEach(delegate (MovieReview movieReview)
            { Console.WriteLine(movieReview.ToString()); });
        }
    }
}
