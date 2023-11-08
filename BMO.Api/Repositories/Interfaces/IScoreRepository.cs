using BMO.Api.Models;

namespace BMO.Api.Repositories.Interfaces
{
    public interface IScoreRepository
    {
        public Task<List<Score>> GetTopScoresAsync(long gameId, CancellationToken cancellationToken = default);
    }
}
