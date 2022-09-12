using CarRental.Common.Models;

namespace CarRental.ApplicationService.CarRegistry
{
    public static class CalculateRentalPrice
    {
        public static decimal Calculate(CarRegistered car, CarTypePrice carTypePrice)
        {

            var basDygnsHyra = carTypePrice.BasDygnsHyra;
            int antalDygn = GetDays(car.Delivered, car.Returned);
            var basDygnsHyraModifier = carTypePrice.BasDygnsHyraModifier;
            var basKmPris = carTypePrice.BasKmPris;
            var antalKm = GetKm(car.EndMileageInKm, car.StartMileageInKm);
            var basKmPrisModifier = carTypePrice.BasKmPrisModifier;

            return (basDygnsHyra * antalDygn * basDygnsHyraModifier) + (basKmPris * antalKm * basKmPrisModifier);
        }

        private static decimal GetKm(double endMilageKm, double startMilageKm)
        {
            return (decimal)(endMilageKm - startMilageKm);
        }

        private static int GetDays(DateTime delivered, DateTime returned)
        {
            var days = (returned - delivered).TotalDays;
            return (int)Math.Ceiling(days);
        }
    }
}
