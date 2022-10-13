namespace MovieStore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Actor>? ActorList { get; set; }
        public Director Director { get; set; }
        public MovieGenre Genre { get; set; }
        public int GenreId { get; set; }
        public float Price { get; set; }



    }
}
