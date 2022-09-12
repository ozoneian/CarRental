namespace CarRental.ApplicationService
{
    public abstract class Command : ICommand
    {
        protected Command(string aggregateId)
        {
            AggregateId = aggregateId;
        }

        public string AggregateId { get; private set; }

        public abstract AggregateIdType AggregateIdType { get; }

        public abstract Guid CommandTypeId { get; }

        public abstract string Description { get; }
    }
}
