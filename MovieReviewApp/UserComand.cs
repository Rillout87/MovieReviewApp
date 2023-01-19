using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    /* Класс UserCommand выступает в качестве адаптера запросов от пользователя
    * и содержит инструменты для инициирования обработки запросов -
    * модель запуска обработки запроса и метод для передачи запроса в приложение
    * */
    internal class UserCommand : IUserInput
    {
        private Model model;

        public UserCommand(IFetchMovieReviews fetchMovieReviews, IPrintMovieReviews printMovieReviews)
        {
            MovieApp movieApp = new MovieApp(fetchMovieReviews, printMovieReviews);
            this.model = new Model(movieApp);
        }

        /* Метод HandleUserInput отлавливает запрос пользователя, запускает
         * основную логику приложения и передает запрос в модель
         */
        public void HandleUserInput(Object userCommand)
        {
            model.Run((MovieSearchRequest)userCommand);
        }
    }
}
