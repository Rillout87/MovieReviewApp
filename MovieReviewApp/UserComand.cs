using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    internal class UserCommand : IUserInput
    {
        private Model model;

        public UserCommand(IFetchMovieReviews fetchMovieReviews, IPrintMovieReviews printMovieReviews)
        {
            MovieApp movieApp = new MovieApp(fetchMovieReviews, printMovieReviews);
            this.model = new Model(movieApp);
        }

        public void HandleUserInput(Object userCommand)
        {
            model.Run((MovieSearchRequest)userCommand);
        }
    }
}
