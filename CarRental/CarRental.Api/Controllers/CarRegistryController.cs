using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRegistryController : ControllerBase
    {
        [HttpPost("RegisterDelivery")]
        public void DeliverCar()
        {
           
        }

        [HttpPost("RegisterReturn")]
        public decimal ReturnCarAndGetPayment()
        {
            return 0;
        }
    }
}
