using ProEventos.Core.Common;

namespace ProEventos.Core.Entities
{
    public sealed class Instagram : EntityBase
    {
        public Instagram(string url, Guid eventId) : base()
        {
            Url = url;
            EventId = eventId;
        }

        public string Url { get; private set; }
        public Guid EventId { get; set; }

        public void Update(string newUrl)
        {
            Url = newUrl;
        }
    }
}