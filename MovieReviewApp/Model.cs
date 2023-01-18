using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Model
    {
        private MovieApp movieApp;

        public Model(MovieApp movieApp)
        {
            this.movieApp = movieApp;
        }

        public void Run(MovieSearchRequest movieSearchRequest)
        {
            movieApp.Accept(movieSearchRequest);
        }
    }
}
