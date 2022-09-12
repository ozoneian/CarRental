using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Api.CarRegistry.Contract
{
    public class CarReturnRegistration
    {
        public string BookingNumber { get; set; }
        public DateTime Returned { get; set; }
        public double MileageInKm { get; set; }
    }
}
