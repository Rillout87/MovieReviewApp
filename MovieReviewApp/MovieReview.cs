using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class MovieReview
    {
        private string movieName;
        private double movieScore;
        private string remark;

        public MovieReview(string movieName, double movieScore, string remark)
        {
            this.movieName = movieName;
            this.movieScore = movieScore;
            this.remark = remark;
        }

        public override string ToString()
        {
            return " " + movieScore + " " + remark;
        }
    }
}
