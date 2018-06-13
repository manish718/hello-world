using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeltaXMovie.Models
{
    public class Actors
    {
        public int Actor_ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public System.DateTime DOB { get; set; }
        public string Bio { get; set; }
    }
}