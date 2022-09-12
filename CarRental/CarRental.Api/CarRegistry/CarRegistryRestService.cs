using CarRental.Api.CarRegistry.Contract;
using CarRental.ApplicationService.CarRegistry.Interface;
using CarRental.Common.Models;

namespace CarRental.Api.CarRegistry
{
    public class CarRegistryRestService : ICarRegistryRestService
    {
        private readonly ICarRegistryApplicationService _carRegistryApplicationService;

        public CarRegistryRestService(ICarRegistryApplicationService carRegistryApplicationService)
        {
            _carRegistryApplicationService = carRegistryApplicationService;
        }

        public Task RegisterDelivery(CarDeliveryRegistration carDeliveryRegistration)
        {
             return _carRegistryApplicationService.RegisterCarForDelivery(Map(carDeliveryRegistration));
        }
        public Task<decimal> RegisterReturn(CarReturnRegistration carReturnRegistration)
        {
            return _carRegistryApplicationService.RegisterCarForReturn(Map(carReturnRegistration));
        }

        private CarRegistered Map(CarReturnRegistration carReturnRegistration)
        {
            return new CarRegistered()
            {
                BookingNumber = carReturnRegistration.BookingNumber,
                Returned = carReturnRegistration.Returned,
                EndMileageInKm = carReturnRegistration.MileageInKm
            };

        }

        private CarRegistered Map(CarDeliveryRegistration carDeliveryRegistration)
        {
            return new CarRegistered()
            {
                BookingNumber = carDeliveryRegistration.BookingNumber,
                RegistrationNumber = carDeliveryRegistration.RegistrationNumber,
                SocialSecurityNumber = carDeliveryRegistration.SocialSecurityNumber,
                CarType = carDeliveryRegistration.CarType,
                Delivered = carDeliveryRegistration.Delivered,
                StartMileageInKm = carDeliveryRegistration.MileageInKm
            };
        }
    }
}
