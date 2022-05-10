using System;
using System.Collections.Generic;

namespace Class_6_IMDB_Project_V2.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
