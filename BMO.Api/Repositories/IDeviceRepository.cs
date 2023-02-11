using BMO.Api.Models;

namespace BMO.Api.Repositories
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        IEnumerable<Device> GetDevicesWithoutWarranty();
    }
}
