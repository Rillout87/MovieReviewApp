﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal interface IPrintMovieReviews
    {
        public void WriteMovieReviews(List<MovieReview> movieReviewList);
    }
}
