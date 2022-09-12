using CarRental.Infrastructure;
namespace CarRental.ApplicationService.CarRegistry
{
    public class CarRegistryApplicationService
    {
        private readonly IUnknownDataStorage _unknownDataStorage;

        public CarRegistryApplicationService(IUnknownDataStorage unknownDataStorage)
        {
            _unknownDataStorage = unknownDataStorage;
        }

        void RegisterCarForDelivery()
        {
            _unknownDataStorage.RegisterCarForDelivery();
            //basdygnhyra*antaldyygn*basdygnshyramodifier+baskmpris*antalkm*baskmprismodifier
            //400*5*1 + 100*50*0
            //400*5*1.3 + 100*50*1
            //400*5*1.5 + 100*50*1.5
        }

        void RegisterCarForReturn()
        {
            const string bookingId = "hej";

            var car = _unknownDataStorage.GetRegisteredCar(bookingId);
            var carTypePrices = _unknownDataStorage.GetCarTypePrices(car.CarType);

            var price = CalculateRentalPrice.Calculate(carTypePrices.BasDygnsHyra, 1, (decimal)carTypePrices.BasDygnsHyraModifier, carTypePrices.BasKmPris, 1, (decimal)carTypePrices.BasDygnsHyraModifier);

            _unknownDataStorage.RegisterCarForReturn();
        }
    }
}
