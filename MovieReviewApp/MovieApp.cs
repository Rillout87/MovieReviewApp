using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application
{
    // Основная логика приложения, совершает запрос информации о фильме в БД, фильтр случайных отзывов
    // и запрос вывода их на экран
    internal class MovieApp
    {
        private IFetchMovieReviews fetchMovieReviews;
        private IPrintMovieReviews printMovieReviews;
        private static Random rand = new ();

        public MovieApp(IFetchMovieReviews fetchMovieReviews, IPrintMovieReviews printMovieReviews)
        {
            this.fetchMovieReviews = fetchMovieReviews;
            this.printMovieReviews = printMovieReviews;
        }

        // Метод FilterRandomReviews отвечает за отбор из списка отзывов 5 случайных
        private List<MovieReview> FilterRandomReviews(List<MovieReview> movieReviewList)
        {
            List<MovieReview> result = new List<MovieReview>();
            // logic to return random reviews
            for (int index = 0; index < 5; ++index)
            {
                if (movieReviewList.Count < 1)
                    break;
                int randomIndex = GetRandomElement(movieReviewList.Count);
                MovieReview movieReview = movieReviewList[randomIndex];
                movieReviewList.Remove(movieReview);
                result.Add(movieReview);
            }
            return result;
        }

        private int GetRandomElement(int size)
        {
            return rand.Next(size);
        }

        /* Метод Accept инициирует запрос всех отзывов по конкретному фильму в БД,
         * запрашивает отбор случайных и запрос вывода их на экран
         */
        public void Accept(MovieSearchRequest movieSearchRequest)
        {
            List<MovieReview> movieReviewList = fetchMovieReviews.FetchMovieReviews(movieSearchRequest);
            List<MovieReview> randomReviews = FilterRandomReviews(new List<MovieReview>(movieReviewList));
            printMovieReviews.WriteMovieReviews(randomReviews);
        }
    }
}
