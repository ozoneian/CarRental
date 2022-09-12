using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.ApplicationService.CarRegistry.Interface
{
    public interface ICarRegistryApplicationService
    {
        void When(CreateCarRegistrationCommand command);
        decimal When(ReturnCarRegistrationCommand command);
    }
}
