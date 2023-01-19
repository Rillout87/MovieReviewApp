using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    // Интерфейс описывает метод запроса в БД
    internal interface IFetchMovieReviews
    {
        public List<MovieReview> FetchMovieReviews(MovieSearchRequest movieSearchRequest);
    }
}
