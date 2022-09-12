using CarRental.Common.Models;

namespace CarRental.Infrastructure
{
    public interface IUnknownDataStorage
    {
        void RegisterCarForDelivery(CarRegistered carRegistered);
        CarRegistered GetRegisteredCar(string bookingId);

        CarTypePrice GetCarTypePrices(int carType);
    }
}
