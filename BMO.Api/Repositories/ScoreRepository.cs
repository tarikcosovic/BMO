using BMO.Api.Models;

namespace BMO.Api.Repositories
{
    public class ScoreRepository : GenericRepository<Score>
    {
        public ScoreRepository(BmodbContext dbContext) : base(dbContext)
        {

        }
    }
}
