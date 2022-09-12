using CarRental.Api.CarRegistry.Contract;

namespace CarRental.Api.CarRegistry
{
    public interface ICarRegistryRestService
    {
        void RegisterDelivery(CarDeliveryRegistration carDeliveryRegistration);
        decimal RegisterReturn(CarReturnRegistration carReturnRegistration);
    }
}
