using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    //Класс MovieReviewsRepo имитирует базу данных
    internal class MovieReviewsRepo : IFetchMovieReviews
    {
        private Dictionary<string, List<MovieReview>>? movieReviewDict;

        // В конструкторе инициализируется имитационная база данных
        public MovieReviewsRepo()
        {
            Initialize();
        }

        // Метод FetchMovieReviews отвечат за вызов отзывов из БД
        public List<MovieReview> FetchMovieReviews(MovieSearchRequest movieSearchRequest)
        {

            List<MovieReview>? value;
            if (movieReviewDict.TryGetValue(movieSearchRequest.GetMovieName(), out value))
            {
                return value;
            }

            return new List<MovieReview>();
        }

        /* В методе Initialize() создается словарь movieReviewDict,
         * содержащий фильмы и отзывы по ним. Для имитации в БД добавляется
         * 2 фильма и списком добавляются экземпляры отзывов
         */ 
        private void Initialize()
        {
            movieReviewDict = new Dictionary<string, List<MovieReview>>();
            List<MovieReview> starWarsReviews = new ();
            starWarsReviews.Add(new MovieReview("1", 7.5, "Good"));
            movieReviewDict.Add("StarWars", starWarsReviews);
            List<MovieReview> starTreckReviews = new();
            starTreckReviews.Add(new MovieReview("1", 9.5, "Excellent"));
            starTreckReviews.Add(new MovieReview("1", 8.5, "Good"));
            movieReviewDict.Add("StarTreck", starTreckReviews);
        }
    }
}
