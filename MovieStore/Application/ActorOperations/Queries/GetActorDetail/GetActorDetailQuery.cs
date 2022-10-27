using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieStore.DBOperations;
using MovieStore.Entities;

namespace MovieStore.Application.ActorOperations.Queries.GetActorDetail
{
    public class GetActorDetailQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int ActorId { get; set; }

        public GetActorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ActorDetailViewModel Handle()
        {
            var actor = _context.Actors.Include(x => x.Movies).SingleOrDefault(x => x.ActorId == ActorId);
            if(actor is null)
            {
                throw new InvalidOperationException("Aranan aktör bulunamadı");
            }
            return _mapper.Map<ActorDetailViewModel>(actor);
        }
    }

    public class ActorDetailViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
