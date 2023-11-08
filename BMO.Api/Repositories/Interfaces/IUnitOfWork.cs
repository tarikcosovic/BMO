namespace BMO.Api.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DeviceRepository Devices { get; }
        GameRepository Games { get; }
        PlayerRepository Players { get; }
        ScoreRepository Scores { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
