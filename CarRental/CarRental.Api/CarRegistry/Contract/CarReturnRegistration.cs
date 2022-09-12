namespace CarRental.Api.CarRegistry.Contract
{
    public class CarReturnRegistration
    {
        public string BookingNumber { get; set; }
        public DateTime Returned { get; set; }
        public double MileageInKm { get; set; }
    }
}
