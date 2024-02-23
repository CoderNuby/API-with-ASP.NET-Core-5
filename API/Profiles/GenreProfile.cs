using API.Entities;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class GenreProfile : Profile
    {
        public GenreProfile() 
        {
            CreateMap<Genre, GenreDto>().ReverseMap();
        }
    }
}
