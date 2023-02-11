using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BMO.Api.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(BmodbContext dbContext) : base(dbContext) { }

        public IEnumerable<Device> GetDevicesWithoutWarranty() => BmodbContext.Devices.ToList();

        private BmodbContext BmodbContext
        {
            get { return (_dbContext as BmodbContext)!; }
        }
    }
}
