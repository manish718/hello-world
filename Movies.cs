using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXMovie.Models
{
    public class Movies
    {
        public int Movie_ID { get; set; }
        public System.DateTime YearOfRelease { get; set; }
        public string Plot { get; set; }
        public byte[] Poster { get; set; }
        public Producer Producer { get; set; }
        public Nullable<int> P_ID { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Movie_Cast> Movie_Cast { get; set; }
        //public virtual Producer Producer { get; set; }
    }
}