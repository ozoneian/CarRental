using CarRental.Api.CarRegistry.Contract;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.CarRegistry
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRegistryController : ControllerBase
    {
        private readonly ICarRegistryRestService _carRegistryRestService;

        public CarRegistryController(ICarRegistryRestService carRegistryRestService)
        {
            _carRegistryRestService = carRegistryRestService;
        }

        [HttpPost("RegisterDelivery")]
        public async Task DeliverCar(CarDeliveryRegistration carDeliveryRegistration)
        {
            await _carRegistryRestService.RegisterDelivery(carDeliveryRegistration);
        }

        [HttpPost("RegisterReturn")]
        public async Task<decimal> ReturnCarAndGetPayment(CarReturnRegistration carReturnRegistration)
        {
            return await _carRegistryRestService.RegisterReturn(carReturnRegistration);
        }
    }
}
