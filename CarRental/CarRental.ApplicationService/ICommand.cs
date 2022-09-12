namespace CarRental.ApplicationService
{
    public interface ICommand
    {
        string AggregateId { get; }
        AggregateIdType AggregateIdType { get; }
        Guid CommandTypeId { get;  }
        string Description { get; }
    }

    public enum AggregateIdType
    {
        BookingNumberId = 0
    }
}
