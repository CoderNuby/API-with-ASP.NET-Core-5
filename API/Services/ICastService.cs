using API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API.Services
{
    public interface ICastService
    {
        List<CastDto> GetAllCasts();
        List<CastDto> GetCastsFromMovie(int movieId);
        CastDto GetCast(int movieId, Guid castId);
        CastDto GetCast(Guid castId);
        CastDto CreateCast(int movieId, CastForCreationDto cast);
        CastDto UpdateCast(int movieId, Guid castId, CastForUpdateDto cast);
        CastDto UpdateCast(int movieId, Guid castId, JsonPatchDocument<CastForUpdateDto> patchDocument);
        CastDto DeleteCast(int movieId, Guid castId);
    }
}
