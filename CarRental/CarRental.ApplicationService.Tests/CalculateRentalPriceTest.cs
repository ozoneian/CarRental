using CarRental.ApplicationService.CarRegistry;
using CarRental.Common.Models;

namespace CarRental.ApplicationService.Tests
{
    public class CalculateRentalPriceTest
    {
        private CarRegistered _mockSmallCarRegistration;
        private CarRegistered _mockKombiCarRegistration;
        private CarRegistered _mockLastBilRegistration;
        private CarTypePrice _mockSmallCarTypePrice;
        private CarTypePrice _mockKombiCarTypePrice;
        private CarTypePrice _mockLastBilTypePrice;

        [SetUp]
        public void Setup() 
        {
            _mockSmallCarRegistration = new CarRegistered()
            {
                BookingNumber = "134abc",
                RegistrationNumber = "ABC-564",
                CarType = 1,
                StartMileageInKm = 4503.23,
                EndMileageInKm = 6743.23,
                SocialSecurityNumber = "xxx",
                Delivered = new DateTime(2015, 12, 27),
                Returned = new DateTime(2015, 12, 31),
            };

            _mockKombiCarRegistration = new CarRegistered()
            {
                BookingNumber = "134abc",
                RegistrationNumber = "ABC-564",
                CarType = 2,
                StartMileageInKm = 4503.23,
                EndMileageInKm = 6743.23,
                SocialSecurityNumber = "xxx",
                Delivered = new DateTime(2015, 12, 27),
                Returned = new DateTime(2015, 12, 31),
            };

            _mockLastBilRegistration = new CarRegistered()
            {
                BookingNumber = "134abc",
                RegistrationNumber = "ABC-564",
                CarType = 3,
                StartMileageInKm = 4503.23,
                EndMileageInKm = 6743.23,
                SocialSecurityNumber = "xxx",
                Delivered = new DateTime(2015, 12, 27),
                Returned = new DateTime(2015, 12, 31),
            };

            _mockSmallCarTypePrice = new CarTypePrice()
            {
                CarTypeId = 1,
                BasDygnsHyra = 368,
                BasDygnsHyraModifier = 1,
                BasKmPrisModifier = 0,
                BasKmPris = 23
            };

            _mockKombiCarTypePrice = new CarTypePrice()
            {
                CarTypeId = 2,
                BasDygnsHyra = 368,
                BasDygnsHyraModifier = (decimal)1.3,
                BasKmPrisModifier = 1,
                BasKmPris = 23
            };

            _mockLastBilTypePrice = new CarTypePrice()
            {
                CarTypeId = 3,
                BasDygnsHyra = 368,
                BasDygnsHyraModifier = (decimal)1.5,
                BasKmPrisModifier = (decimal)1.5,
                BasKmPris = 23
            };
        }

        [Test]
        public void Should_Calculate_SmallCar_Rental_Fee()
        {
            const decimal expectedPrice = 1472;

            var price = CalculateRentalPrice.Calculate(_mockSmallCarRegistration, _mockSmallCarTypePrice);

            Assert.That(price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Should_Calculate_Kombi_Rental_Fee()
        {
            const decimal expectedPrice = (decimal)53433.6;

            var price = CalculateRentalPrice.Calculate(_mockKombiCarRegistration, _mockKombiCarTypePrice);

            Assert.That(price, Is.EqualTo(expectedPrice));
        }

        [Test]
        public void Should_Calculate_LastBil_Rental_Fee()
        {
            const decimal expectedPrice = 79488;

            var price = CalculateRentalPrice.Calculate(_mockLastBilRegistration, _mockLastBilTypePrice);

            Assert.That(price, Is.EqualTo(expectedPrice));
        }
    }
}
