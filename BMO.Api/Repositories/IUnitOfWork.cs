namespace BMO.Api.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        DeviceRepository Devices { get; }
        GameRepository Games { get; }
        PlayerRepository Players { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
