using Microsoft.EntityFrameworkCore;
using MovieStore.Entities;

namespace MovieStore.DBOperations
{
    public interface IMovieStoreDbContext
    {
        DbSet<Actor> Actors { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Director> Directors { get; set; }
        DbSet<MovieGenre> Genres { get; set; }

        int SaveChanges();

    }
}
