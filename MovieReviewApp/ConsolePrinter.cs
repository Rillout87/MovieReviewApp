using Domain;
using Application;

namespace Adapters
{
    // Класс ConsolePrinter отвечает за вывод информации и отзывов о фильме в консоль
    internal class ConsolePrinter : IPrintMovieReviews
    {

        public void WriteMovieReviews(List<MovieReview> movieReviewList)
        {
            movieReviewList.ForEach(delegate (MovieReview movieReview)
            { Console.WriteLine(movieReview.ToString()); });
        }
    }
}
