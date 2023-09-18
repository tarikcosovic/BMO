using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using BMO.Api.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMO.Api.Controllers
{
    [ApiController]
    [Authorize("Administrator")]
    [Route("api/devices")]
    public class DeviceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeviceController> _logger;
        private readonly IMapper _mapper;
        public DeviceController(IUnitOfWork unitOfWork, ILogger<DeviceController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateDeviceAsync(CreateDeviceRequest request)
        {
            if (request == null)
                return new BadRequestResult();

            Device response = new();

            try
            {
                _mapper.Map(request, response);

                await _unitOfWork.Devices.AddAsync(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: Create - Device");
            }
            finally
            {
                await _unitOfWork.SaveChangesAsync();

                _unitOfWork.Dispose();
            }

            return new JsonResult(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetDevicesAsync()
        {
            IEnumerable<Device> response = Enumerable.Empty<Device>();

            try
            {
                response = await _unitOfWork.Devices.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetAll - Device");
            }

            return new JsonResult(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeviceAsync(Guid id)
        {
            Device? response = null;

            try
            {
                response = await _unitOfWork.Devices.GetAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while making an api call: GetById - Device");
            }

            return new JsonResult(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDeviceAsync(Guid id)
        {
            Device? response = null;

            try
            {
                response = await _unitOfWork.Devices.GetAsync(id);

                if (response is not null)
                {
                    _unitOfWork.Devices.Remove(response);

                    await _unitOfWork.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while making an api call: Delete Device with id: {id}");
            }

            return new JsonResult(response);
        }
    }
}
