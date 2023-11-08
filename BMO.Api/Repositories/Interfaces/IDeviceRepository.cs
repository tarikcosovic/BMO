using BMO.Api.Models;

namespace BMO.Api.Repositories.Interfaces
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> GetDevicesWithoutWarranty();
    }
}
