namespace CarRental.Common.Models
{
    public class CarTypePrice
    {
        public int CarTypeId { get; set; }
        public decimal BasDygnsHyra { get; set; }
        public decimal BasDygnsHyraModifier { get; set; }
        public decimal BasKmPris { get; set; }
        public decimal BasKmPrisModifier { get; set; }
    }
}
