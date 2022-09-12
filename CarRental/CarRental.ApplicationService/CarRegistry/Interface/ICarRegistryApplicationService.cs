using CarRental.Common.Models;

namespace CarRental.ApplicationService.CarRegistry.Interface
{
    public interface ICarRegistryApplicationService
    {
        Task RegisterCarForDelivery(CarRegistered carRegistered);
        Task<decimal> RegisterCarForReturn(CarRegistered carRegistered);
    }
}
