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
                context.Directors.AddRange(
                    new Director
                    {
                        Name = "Sami",
                        Surname = "Sezgin",
                        Movies = new List<Movie>()
                    }
                    );
            }
        }
    }
}
