using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Entities
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Actor>? ActorList { get; set; }
        public Director Director { get; set; }
        public int MovieDirectorId { get; set; }
        public MovieGenre Genre { get; set; }
        public int GenreId { get; set; }
        public float Price { get; set; }



    }
}
