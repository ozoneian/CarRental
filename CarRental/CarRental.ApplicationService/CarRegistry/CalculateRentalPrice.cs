namespace CarRental.ApplicationService.CarRegistry
{
    public static class CalculateRentalPrice
    {
        public static decimal Calculate(decimal basDygnsHyra, int antalDygn, decimal basDygnsHyraModifier, decimal basKmPris, decimal antalKm, decimal basKmPrisModifier)
        {
            return (basDygnsHyra * antalDygn * basDygnsHyraModifier) + (basKmPris * antalKm * basKmPrisModifier);
        }
    }
}
