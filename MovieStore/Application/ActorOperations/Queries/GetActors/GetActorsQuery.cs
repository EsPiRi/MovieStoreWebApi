using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;

namespace MovieStore.Application.ActorOperations.Queries.GetActors
{
    public class GetActorsQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetActorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ActorViewModel> Handle()
        {
            var actorList = _context.Actors.ToList();
            List<ActorViewModel> actors = _mapper.Map<List<ActorViewModel>>(actorList);
            return actors;
        }
    }

    public class ActorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}