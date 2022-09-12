using CarRental.ApplicationService.CarRegistry.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.ApplicationService.CarRegistry
{
    public class CarRegistryApplicationServiceDecorator : ICarRegistryApplicationService
    {
        public CarRegistryApplicationServiceDecorator()
        {

        }
        public void When(CreateCarRegistrationCommand command)
        {
            throw new NotImplementedException();
        }

        public decimal When(ReturnCarRegistrationCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
