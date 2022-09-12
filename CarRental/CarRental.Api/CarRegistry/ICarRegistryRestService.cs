using CarRental.Api.CarRegistry.Contract;

namespace CarRental.Api.CarRegistry
{
    public interface ICarRegistryRestService
    {
        Task RegisterDelivery(CarDeliveryRegistration carDeliveryRegistration);
        Task<decimal> RegisterReturn(CarReturnRegistration carReturnRegistration);
    }
}
