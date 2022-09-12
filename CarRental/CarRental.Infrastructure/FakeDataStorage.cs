using CarRental.Common.Models;

namespace CarRental.Infrastructure
{
    public class FakeDataStorage : IUnknownDataStorage
    {
        public Task<CarTypePrice> GetCarTypePrices(int carType)
        {
            return null;
        }

        public Task<CarRegistered> GetRegisteredCar(string bookingId)
        {
            return null;
        }

        public Task RegisterCarForDelivery(CarRegistered carRegistered)
        {
            return null;
        }

        public Task RegisterCarForReturn(CarRegistered carRegistered)
        {
            return null;
        }
    }
}
