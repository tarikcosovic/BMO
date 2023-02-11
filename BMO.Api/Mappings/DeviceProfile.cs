using AutoMapper;
using BMO.Api.Models.Requests;
using BMO.Api.Models;

namespace BMO.Api.Mappings
{
    public class DeviceProfile : Profile
    {
        public DeviceProfile() 
        {
            CreateMap<Device, CreateDeviceRequest>().ReverseMap();
        }
    }
}
