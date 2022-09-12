namespace CarRental.Common.Models
{
    public class CarRegistered
    {
        public string BookingNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int CarType { get; set; }
        public DateTime Delivered { get; set; }
        public DateTime Returned { get; set; }
        public double StartMileageInKm { get; set; }
        public double EndMileageInKm { get; set; }
        public decimal Price { get; set; }
    }
}
