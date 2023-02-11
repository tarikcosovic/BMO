using AutoMapper;
using BMO.Api.Models;

namespace BMO.Api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BmodbContext _dbContext;
        public UnitOfWork(BmodbContext dbContext)
        {
            _dbContext = dbContext;

            Devices = new DeviceRepository(dbContext);
            Games = new GameRepository(dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public DeviceRepository Devices { get; private set; }
        public GameRepository Games { get; private set; }
    }
}
