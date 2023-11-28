using BMO.Api.Models;
using BMO.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BMO.Api.Repositories
{
    public class ScoreRepository : GenericRepository<Score>, IScoreRepository
    {
        private BmodbContext BmodbContext
        {
            get { return (_dbContext as BmodbContext)!; }
        }
        public ScoreRepository(BmodbContext dbContext) : base(dbContext) { }

        public async Task<List<Score>> GetTopScoresAsync(long gameId, CancellationToken cancellationToken = default)
        {
            return await BmodbContext.Scores.Where(x => x.GameId == gameId).Include(player => player.Player).Select(x => new Score { Value = x.Value, Player = x.Player, CreatedDate = x.CreatedDate }).OrderByDescending(x => x.Value).ToListAsync(cancellationToken);
        }

        public async Task<Score?> GetScoreByGameAndUsername(long gameId, string username, CancellationToken cancellationToken = default)
        {
            return await BmodbContext.Scores.Where(x => x.GameId == gameId && x.Player.Username == username).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
