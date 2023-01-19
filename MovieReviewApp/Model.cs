using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Класс Model моделирует основную логику приложения и запускает поиск отзывов
    internal class Model
    {
        private MovieApp movieApp;

        public Model(MovieApp movieApp)
        {
            this.movieApp = movieApp;
        }

        // Метод запускает поиск отзывов
        public void Run(MovieSearchRequest movieSearchRequest)
        {
            movieApp.Accept(movieSearchRequest);
        }
    }
}
