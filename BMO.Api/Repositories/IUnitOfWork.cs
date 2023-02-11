namespace BMO.Api.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        DeviceRepository Devices { get; }
        GameRepository Games { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
