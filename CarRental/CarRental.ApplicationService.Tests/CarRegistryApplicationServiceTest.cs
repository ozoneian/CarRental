using CarRental.ApplicationService.CarRegistry;
using CarRental.Infrastructure;
using Moq;

namespace CarRental.ApplicationService.Tests
{
    public class CarRegistryApplicationServiceTest
    {
        private CarRegistryApplicationService _carRegistryApplicationService;

        [SetUp]
        public void Setup()
        {
            Mock<IUnknownDataStorage> mockDataStorage = new Mock<IUnknownDataStorage>();

            _carRegistryApplicationService = new CarRegistryApplicationService(mockDataStorage.Object);
        }
    }
}