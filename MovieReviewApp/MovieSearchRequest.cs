using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class MovieSearchRequest
    {
        private string request;

        public MovieSearchRequest(string name)
        {
            this.request = name;
        }

        public string GetMovieName()
        {
            return request;
        }
    }
}
