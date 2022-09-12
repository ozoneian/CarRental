using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.ApplicationService.CarRegistry.Interface.Commands
{
    public class CreateCarRegistrationCommand : Command
    {
        public override AggregateIdType AggregateIdType => AggregateIdType.BookingNumberId;

        public override Guid CommandTypeId => new Guid("1227D957-3809-42D5-9C29-146045378881");

        public override string Description => "Car Registered For Delivery";
    }
}
