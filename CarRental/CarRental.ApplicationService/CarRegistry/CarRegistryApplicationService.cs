using CarRental.ApplicationService.CarRegistry.Interface;
using CarRental.Common.Models;
using CarRental.Infrastructure;

namespace CarRental.ApplicationService.CarRegistry
{
    public class CarRegistryApplicationService : ICarRegistryApplicationService
    {
        private readonly IUnknownDataStorage _unknownDataStorage;

        public CarRegistryApplicationService(IUnknownDataStorage unknownDataStorage)
        {
            _unknownDataStorage = unknownDataStorage;
        }

        public Task RegisterCarForDelivery(CarRegistered carRegistered)
        {
            return _unknownDataStorage.RegisterCarForDelivery(carRegistered);
        }

        public async Task<decimal> RegisterCarForReturn(CarRegistered carRegistered)
        {
            var car = await _unknownDataStorage.GetRegisteredCar(carRegistered.BookingNumber);

            var carTypePrices = await _unknownDataStorage.GetCarTypePrices(car.CarType);

            var updatedCar = UpdateCarRegistration(car, carRegistered);

            var price = CalculateRentalPrice.Calculate(updatedCar, carTypePrices);

            updatedCar.Price = price;

            await _unknownDataStorage.RegisterCarForReturn(updatedCar);

            return price;
        }

        private CarRegistered UpdateCarRegistration(CarRegistered car, CarRegistered carRegistered)
        {
            car.Returned = carRegistered.Returned;
            car.EndMileageInKm = carRegistered.EndMileageInKm;

            return car;
        }
    }
}
