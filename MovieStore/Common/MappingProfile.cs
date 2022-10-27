using AutoMapper;
using MovieStore.Application.ActorOperations.Queries.GetActorDetail;
using MovieStore.Application.ActorOperations.Queries.GetActors;
using MovieStore.Entities;

namespace MovieStore.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Actor, ActorDetailViewModel>();
        }
       
    }
}
