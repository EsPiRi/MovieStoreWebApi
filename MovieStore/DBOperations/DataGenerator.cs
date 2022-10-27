using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MovieStore.Entities;

namespace MovieStore.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }
                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "Movie1Name",
                        MovieDirectorId = 1,
                        Year = 1990,
                        GenreId = 1,
                        ActorList = new List<Actor>(),
                        Price = 15
                    },
                    new Movie
                    {
                        Name = "Movie2Name",
                        MovieDirectorId = 2,
                        Year = 1991,
                        GenreId = 3,
                        ActorList = new List<Actor>(),
                        Price = 20
                    },
                    new Movie
                    {
                        Name = "Movie3Name",
                        MovieDirectorId = 3,
                        Year = 1992,
                        GenreId = 2,
                        ActorList = new List<Actor>(),
                        Price = 25
                    }
                    );
                context.Customers.AddRange(
                    new Customer
                    {
                        Name = "Customer1Name",
                        Surname = "Customer1Surname",
                        MovieCart = new List<Movie>(),
                        BoughtMovies = new List<Movie>(),
                        FavoriteGenres = new List<MovieGenre>()
                    },
                    new Customer
                    {
                        Name = "Customer2Name",
                        Surname = "Customer2Surname",
                        MovieCart = new List<Movie>(),
                        BoughtMovies = new List<Movie>(),
                        FavoriteGenres = new List<MovieGenre>()
                    },
                    new Customer
                    {
                        Name = "Customer3Name",
                        Surname = "Customer3Surname",
                        MovieCart = new List<Movie>(),
                        BoughtMovies = new List<Movie>(),
                        FavoriteGenres = new List<MovieGenre>()
                    },
                    new Customer
                    {
                        Name = "Customer4Name",
                        Surname = "Customer4Surname",
                        MovieCart = new List<Movie>(),
                        BoughtMovies = new List<Movie>(),
                        FavoriteGenres = new List<MovieGenre>()
                    },
                    new Customer
                    {
                        Name = "Customer5Name",
                        Surname = "Customer5Surname",
                        MovieCart = new List<Movie>(),
                        BoughtMovies = new List<Movie>(),
                        FavoriteGenres = new List<MovieGenre>()
                    }
                    );
                context.Actors.AddRange(
                    new Actor
                    {
                        Name = "Actor1Name",
                        Surname = "Actor1Surname",
                        Movies = new List<Movie>()
                        { 
                            new Movie()
                            {
                                Id=1
                            }
                        }

                    },
                    new Actor
                    {
                        Name = "Actor2Name",
                        Surname = "Actor2Surname",
                        Movies = new List<Movie>()
                    },
                    new Actor
                    {
                        Name = "Actor3Name",
                        Surname = "Actor3Surname",
                        Movies = new List<Movie>()
                    },
                    new Actor
                    {
                        Name = "Actor4Name",
                        Surname = "Actor4Surname",
                        Movies = new List<Movie>()
                    },
                    new Actor
                    {
                        Name = "Actor5Name",
                        Surname = "Actor5Surname",
                        Movies = new List<Movie>()
                    }
                    );

                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Director1Name",
                        Surname = "Director1Surname",
                        Movies = new List<Movie>()
                    },
                    new Director
                    {
                        Name = "Director2Name",
                        Surname = "Director2Surname",
                        Movies = new List<Movie>()
                    },
                    new Director
                    {
                        Name = "Director3Name",
                        Surname = "Director3Surname",
                        Movies = new List<Movie>()
                    },
                    new Director
                    {
                        Name = "Director4Name",
                        Surname = "Director4Surname",
                        Movies = new List<Movie>()
                    },
                    new Director
                    {
                        Name = "Director5Name",
                        Surname = "Director5Surname",
                        Movies = new List<Movie>()
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
