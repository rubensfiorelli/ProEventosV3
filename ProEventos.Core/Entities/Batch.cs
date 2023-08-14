using ProEventos.Core.Common;

namespace ProEventos.Core.Entities
{
    public sealed class Batch : EntityBase
    {
        public Batch(string title, decimal price, int amount, Guid eventId) : base()
        {
            Title = title;
            Price = price;
            StartDate = DateTime.Today;
            EndDate = DateTime.UtcNow.AddDays(15);
            Amount = amount;
            EventId = eventId;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Amount { get; private set; }
        public Guid EventId { get; private set; }
        public Event? Event { get; set; }

        public void Update(string newTitle, decimal newPrice, DateTime newEndDate, int newAmount)
        {
            Title = newTitle;
            Price = newPrice;
            Amount = newAmount;
            EndDate = newEndDate;

        }
    }
}