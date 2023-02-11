using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BMO.Api.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(BmodbContext dbContext) : base(dbContext) { }

        private BmodbContext BmodbContext
        {
            get { return (_dbContext as BmodbContext)!; }
        }

        public override async Task<Device> AddAsync(Device entity, CancellationToken cancellationToken = default)
        {
            entity.LastModifiedDate= DateTime.UtcNow;
            entity.CreatedDate= DateTime.UtcNow;
            entity.SerialNumber = Guid.NewGuid().ToString();

            await base.AddAsync(entity, cancellationToken);

            return entity;
        }

        public IEnumerable<Device> GetDevicesWithoutWarranty() => BmodbContext.Devices.Where(x => !x.Warranty).ToList();
    }
}
