using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    // Класс MovieUser - это порт для получения запросов от пользователя
    internal class MovieUser
    {
        private IUserInput userInputDriverPort;

        public MovieUser(IUserInput userInputDriverPort)
        {
            this.userInputDriverPort = userInputDriverPort;
        }

        // Метода ProcessInput имитирует поступление запроса от пользователя
        public void ProcessInput(MovieSearchRequest movieSearchRequest)
        {
            userInputDriverPort.HandleUserInput(movieSearchRequest);
        }
    }
}
