using System;
using System.Collections.Generic;

namespace Class_6_IMDB_Project_V2.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? ReleaseDate { get; set; }
        public decimal Budget { get; set; }
        public TimeSpan? RunTime { get; set; }
        public int? GenreId { get; set; }

        public virtual Genre? Genre { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
