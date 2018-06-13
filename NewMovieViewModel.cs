using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXMovie.Models
{
    public class NewMovieViewModel
    {
        public Movies Movie { get; set; }
        public Producer Producer { get; set; }
        //public IEnumerable<Actors> Actors { get; set; }
    }
}