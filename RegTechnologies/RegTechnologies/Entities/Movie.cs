using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegTechnologies.Entities
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public int Popularity { get; set; }

        public ICollection<Comment> Comments { get; set; }
          = new List<Comment>();
    }
}
