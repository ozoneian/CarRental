using CarRental.Common.Models;

namespace CarRental.Infrastructure
{
    public class FakeDataStorage : IUnknownDataStorage
    {
        public CarTypePrice GetCarTypePrices(int carType)
        {
            throw new NotImplementedException();
        }

        public CarRegistered GetRegisteredCar(string bookingId)
        {
            throw new NotImplementedException();
        }

        public void RegisterCarForDelivery(CarRegistered carRegistered)
        {
            throw new NotImplementedException();
        }
    }
}
