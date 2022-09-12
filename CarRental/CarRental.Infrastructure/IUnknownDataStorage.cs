using CarRental.Common.Models;

namespace CarRental.Infrastructure
{
    public interface IUnknownDataStorage
    {
        Task RegisterCarForDelivery(CarRegistered carRegistered);
        Task RegisterCarForReturn(CarRegistered carRegistered);
        Task<CarRegistered> GetRegisteredCar(string bookingId);

        Task<CarTypePrice> GetCarTypePrices(int carType);
    }
}
