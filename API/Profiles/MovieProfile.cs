using API.Entities;
using API.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace API.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile() 
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
        }
    }
}
