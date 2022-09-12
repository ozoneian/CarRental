namespace CarRental.Api.CarRegistry.Contract
{
    public class CarDeliveryRegistration
    {
        public string BookingNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int CarType { get; set; }
        public DateTime Delivered { get; set; }
        public double MileageInKm { get; set; }
    }
}
