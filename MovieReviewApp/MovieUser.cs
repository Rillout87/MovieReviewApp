using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class MovieUser
    {
        private IUserInput userInputDriverPort;

        public MovieUser(IUserInput userInputDriverPort)
        {
            this.userInputDriverPort = userInputDriverPort;
        }

        public void ProcessInput(MovieSearchRequest movieSearchRequest)
        {
            userInputDriverPort.HandleUserInput(movieSearchRequest);
        }
    }
}
