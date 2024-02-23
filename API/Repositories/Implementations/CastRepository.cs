using API.Context;
using API.Entities;

namespace API.Repositories.Implementations
{
    public class CastRepository : Repository<Cast>, ICastRepository
    {
        public CastRepository(MovieInfoContext context) : base(context)
        {
        }
    }
}
