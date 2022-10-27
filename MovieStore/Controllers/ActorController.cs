using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Application.ActorOperations.Queries.GetActorDetail;
using MovieStore.Application.ActorOperations.Queries.GetActors;
using MovieStore.DBOperations;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class AuthorController:ControllerBase
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public AuthorController(MovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetActors()
        {
            GetActorsQuery query = new GetActorsQuery(_dbContext, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetActorDetails(int id)
        {
            GetActorDetailQuery query= new GetActorDetailQuery(_dbContext, _mapper);
            query.ActorId = id;
            var result = query.Handle();
            return Ok(result);
        }
    }
}