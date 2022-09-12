using CarRental.Api.CarRegistry.Contract;
using CarRental.ApplicationService.CarRegistry.Interface;

namespace CarRental.Api.CarRegistry
{
    public class CarRegistryRestService : ICarRegistryRestService
    {
        private readonly ICarRegistryApplicationService _carRegistryApplicationService;

        public CarRegistryRestService(ICarRegistryApplicationService carRegistryApplicationService)
        {
            _carRegistryApplicationService = carRegistryApplicationService;
        }

        public void RegisterDelivery(CarDeliveryRegistration carDeliveryRegistration)
        {
        }

        public decimal RegisterReturn(CarReturnRegistration carReturnRegistration)
        {
            throw new NotImplementedException();
        }
    }
}
