using System;
using System.Collections.Generic;

namespace Class_6_IMDB_Project_V2.Models
{
    public partial class MovieActor
    {
        public int Id { get; set; }
        public int? ActorId { get; set; }
        public int? MovieId { get; set; }

        public virtual Actor? Actor { get; set; }
        public virtual Movie? Movie { get; set; }
    }
}
