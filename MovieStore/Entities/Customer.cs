using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> BoughtMovies { get; set; }
        public List<MovieGenre> FavoriteGenres { get; set; }
        public List<Movie> MovieCart { get; set; }
    }
}
