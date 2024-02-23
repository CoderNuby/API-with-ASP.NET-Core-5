using API.Entities;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class CastProfile : Profile
    {
        public CastProfile() 
        {
            CreateMap<Cast, CastDto>().ReverseMap();
            CreateMap<Cast, CastForUpdateDto>().ReverseMap();
        }
    }
}
