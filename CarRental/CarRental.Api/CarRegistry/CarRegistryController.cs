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
        public void DeliverCar(CarDeliveryRegistration carDeliveryRegistration)
        {
            _carRegistryRestService.RegisterDelivery(carDeliveryRegistration);
        }

        [HttpPost("RegisterReturn")]
        public decimal ReturnCarAndGetPayment(CarReturnRegistration carReturnRegistration)
        {
            return _carRegistryRestService.RegisterReturn(carReturnRegistration);
        }
    }
}
