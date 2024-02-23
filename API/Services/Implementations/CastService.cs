using API.Entities;
using API.Models;
using API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace API.Services.Implementations
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;
        private readonly IMovieReporitory _movieRepository;
        private readonly IMapper _mapper;

        public CastService(ICastRepository castRepository, IMovieReporitory movieReporitory, IMapper mapper) 
        {
            _castRepository = castRepository ?? throw new ArgumentNullException(nameof(castRepository));
            _movieRepository = movieReporitory ?? throw new ArgumentNullException(nameof(movieReporitory));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public List<CastDto> GetAllCasts()
        {
            var castsDB = _castRepository.GetAll();

            var casts = _mapper.Map<IEnumerable<CastDto>>(castsDB);

            return casts.ToList();
        }

        public CastDto GetCast(int movieId, Guid castId)
        {
            var castDB = _castRepository.Get(d => d.MovieId == movieId, d => d.Id == castId).FirstOrDefault();
            if (castDB == null)
                return null;

            var cast = _mapper.Map<CastDto>(castDB);

            return cast;
        }

        public CastDto GetCast(Guid castId)
        {
            var castDB = _castRepository.Get(castId);

            if (castDB == null)
                return null;

            var cast = _mapper.Map<CastDto>(castDB);

            return cast;
        }

        public List<CastDto> GetCastsFromMovie(int movieId)
        {
            var castsDB = _castRepository.Get(d => d.MovieId == movieId);

            if (castsDB == null)
                return null;

            var casts = _mapper.Map<IEnumerable<CastDto>>(castsDB);

            return casts.ToList();
        }

        public CastDto CreateCast(int movieId, CastForCreationDto castDto)
        {
            var movie = _movieRepository.Get(movieId);
            if (movie == null)
                return null;

            var cast = _castRepository.Create(new Cast
            {
                Id = Guid.NewGuid(),
                MovieId = movieId,
                Name = castDto.Name
            });

            var response = _mapper.Map<CastDto>(cast);

            return response;
        }

        public CastDto UpdateCast(int movieId, Guid castId, CastForUpdateDto castDto)
        {
            var movie = _movieRepository.Get(movieId);
            if (movie == null)
                return null;

            var cast = _castRepository.Get(castId);
            if (cast == null)
                return null;

            cast.Name = castDto.Name;
            _castRepository.SaveChange();

            var response = _mapper.Map<CastDto>(cast);

            return response;
        }

        public CastDto DeleteCast(int movieId, Guid castId)
        {
            var movie = _movieRepository.Get(movieId);
            if(movie == null)
                return null;

            var cast = _castRepository.Get(castId);
            if(cast == null)
                return null;

            cast = _castRepository.Delete(cast);

            var response = _mapper.Map<CastDto>(cast);

            return response;
        }

        public CastDto UpdateCast(int movieId, Guid castId, JsonPatchDocument<CastForUpdateDto> patchDocument)
        {
            var movie = _movieRepository.Get(movieId);
            if (movie == null)
                return null;

            var castFromStore = _castRepository.Get(castId);
            if (castFromStore == null)
                return null;

            var castToPatch = _mapper.Map<CastForUpdateDto>(castFromStore);
            
            patchDocument.ApplyTo(castToPatch);

            castFromStore.Name = castToPatch.Name;

            _mapper.Map(castToPatch, castFromStore);
            _castRepository.SaveChange();

            return _mapper.Map<CastDto>(castFromStore);
        }
    }
}
