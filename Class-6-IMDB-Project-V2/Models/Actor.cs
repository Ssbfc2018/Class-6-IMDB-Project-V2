using System;
using System.Collections.Generic;

namespace Class_6_IMDB_Project_V2.Models
{
    public partial class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string City { get; set; } = null!;
        public DateTime Birthday { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
