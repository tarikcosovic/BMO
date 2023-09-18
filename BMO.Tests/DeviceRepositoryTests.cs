using Microsoft.EntityFrameworkCore;

namespace BMO.Tests
{
    public class DeviceRepositoryTests
    {
        private readonly BmodbContext _context;
        private readonly DeviceRepository _deviceRepository;

        public DeviceRepositoryTests()
        {
            _context = Substitute.For<BmodbContext>(new DbContextOptions<BmodbContext>());

            _deviceRepository = Substitute.For<DeviceRepository>(_context);
        }

        [Fact]
        public async Task AddAsync_ShouldReturnAddedDevice()
        {
            //arrange
            var expectedDevice = new Device { Id = new Guid("bc9f060c-eea2-4d3e-9d5c-4b175a92504f"), ProductionModel = "Test_Model", Warranty = true };

            _deviceRepository.AddAsync(Arg.Any<Device>(), Arg.Any<CancellationToken>()).Returns(Task.FromResult(expectedDevice), default);

            //act
            var mockDevice = new Device { Id = new Guid("bc9f060c-eea2-4d3e-9d5c-4b175a92504f"), ProductionModel = "Test_Model_2", Warranty = true };

            var actualDevice = await _deviceRepository.AddAsync(mockDevice, default);

            //assert
            await _deviceRepository.Received().AddAsync(mockDevice, default);

            Assert.Equal(expectedDevice, actualDevice, new DeviceComparer());
        }

        [Fact]
        public void GetDevicesWithoutWarranty_ShouldReturnDevicesWithoutWarranty()
        {
            //Arrange
            var expectedDevices = new List<Device>
            {
                new Device { Id = new Guid("bc9f060c-eea2-4d3e-9d5c-4b175a92504f"), ProductionModel = "Test_Model", Warranty = false },
                new Device { Id = new Guid("b59f060c-eea2-4d3e-9b5c-4b175a92504f"), ProductionModel = "Test_Model_2", Warranty = false },
                new Device { Id = new Guid("53116ce8-5619-11ee-8c99-0242ac120002"), ProductionModel = "Test_Model_3", Warranty = false },
            };

            _deviceRepository.GetDevicesWithoutWarranty().Returns(expectedDevices);

            //Act
            var result = _deviceRepository.GetDevicesWithoutWarranty();

            //Assert
            Assert.True(result.Any());
            Assert.True(result.All(device => !device.Warranty));
            Assert.Equal(expectedDevices, result, new DeviceComparer());
        }

        public class DeviceComparer : IEqualityComparer<Device>
        {
            public bool Equals(Device? x, Device? y)
            {
                if (x is null || y is null)
                    throw new ArgumentNullException($"{(x is null ? "x" : "y")} is null");

                return x.Id == y.Id
                    && x.ProductionModel == y.ProductionModel
                    && x.Warranty == y.Warranty;
            }

            public int GetHashCode(Device obj)
            {
                return obj.Id.GetHashCode();
            }
        }
    }
}
