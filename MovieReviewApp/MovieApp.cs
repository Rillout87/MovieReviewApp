using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application
{
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

        public void Accept(MovieSearchRequest movieSearchRequest)
        {
            List<MovieReview> movieReviewList = fetchMovieReviews.FetchMovieReviews(movieSearchRequest);
            List<MovieReview> randomReviews = FilterRandomReviews(new List<MovieReview>(movieReviewList));
            printMovieReviews.WriteMovieReviews(randomReviews);
        }
    }
}
