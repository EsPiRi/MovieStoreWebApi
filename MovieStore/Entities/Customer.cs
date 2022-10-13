namespace MovieStore.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> BoughtMovies { get; set; }
        public List<MovieGenre> FavoriteGenres { get; set; }
        public List<Movie> MovieCart { get; set; }
    }
}
